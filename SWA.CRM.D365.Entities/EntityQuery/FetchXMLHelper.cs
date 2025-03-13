using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace SWA.CRM.D365.Entities.Base
{
    public static class FetchXMLHelper
    {
        public static EntityCollection GetFetchXMLData(string fetchXML, IOrganizationService service)
        {
            return service.RetrieveMultiple(new FetchExpression(fetchXML));
        }

        public static List<Entity> GetFetchXMLDataWithPaging(IOrganizationService service, string fetchXML, int fetchCount = 500)
        {
            List<Entity> objList = new List<Entity>();
            EntityCollection entityCollection = null;
            int pageNumber = 0;

            do
            {
                pageNumber++;

                // Set Paging Cookie
                string fetchQuery = CreateXml(fetchXML, entityCollection?.PagingCookie ?? string.Empty, pageNumber, fetchCount);

                // Execute Fetch
                entityCollection = service.RetrieveMultiple(new FetchExpression(fetchQuery));
                objList.AddRange(entityCollection.Entities);
            }
            while (entityCollection.MoreRecords);

            return objList;
        }

        private static string CreateXml(string xml, string cookie, int page, int count)
        {
            XmlDocument doc = new XmlDocument();
            StringReader StringReader = new StringReader(xml);
            XmlTextReader reader = new XmlTextReader(StringReader);
            // Load document
            doc.Load(reader);

            return CreateXml(doc, cookie, page, count);
        }

        private static string CreateXml(XmlDocument doc, string cookie, int page, int count)
        {
            XmlAttributeCollection attrs = doc.DocumentElement.Attributes;
            if (cookie != null)
            {
                XmlAttribute pagingAttr = doc.CreateAttribute("paging-cookie");
                pagingAttr.Value = cookie;
                attrs.Append(pagingAttr);
            }
            XmlAttribute pageAttr = doc.CreateAttribute("page");
            pageAttr.Value = System.Convert.ToString(page);
            attrs.Append(pageAttr);
            XmlAttribute countAttr = doc.CreateAttribute("count");
            countAttr.Value = System.Convert.ToString(count);
            attrs.Append(countAttr);
            StringBuilder sb = new StringBuilder(1024);
            StringWriter StringWriter = new StringWriter(sb);
            XmlTextWriter writer = new XmlTextWriter(StringWriter);
            doc.WriteTo(writer);
            writer.Close();
            return sb.ToString();
        }

        public static List<EntityReference> GetManyToManyRelationsipData(Entity entity, IOrganizationService service, string relationshipEntityName, string secondaryEntityName)
        {
            List<EntityReference> relatedManyToManyRecords = new List<EntityReference>();

            string fetchXMLgetLinkEntities = @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                                                  <entity name='" + relationshipEntityName + @"'>
                                                    <attribute name='" + secondaryEntityName + "id" + @"' />
                                                    <order attribute='" + relationshipEntityName + "id" + @"' descending='false' />
                                                    <filter type='and'>
                                                      <condition attribute='" + entity.LogicalName + "id" + @"' operator='eq' uitype='" + entity.LogicalName + @"' value='{" + entity.Id + @"}' />
                                                    </filter>
                                                  </entity>
                                                </fetch>"
            ;

            EntityCollection getLinkEntites = GetFetchXMLData(fetchXMLgetLinkEntities, service);

            foreach (Entity intersectEntity in getLinkEntites.Entities)
            {
                Guid guid = (Guid)intersectEntity.Attributes[secondaryEntityName + "id"];
                Entity secondaryEntity = service.Retrieve(secondaryEntityName, guid, new ColumnSet(true));
                EntityReference entRef = secondaryEntity.ToEntityReference();
                relatedManyToManyRecords.Add(entRef);
            }

            return relatedManyToManyRecords;
        }
    }
}
