using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;

namespace SWA.CRM.D365.Entities.Base
{
    public static class EntityExtensions
    {
        public static Entity Clone<E>(this E entity, HashSet<string> includeAttributeList = null, HashSet<string> excludeAttributeList = null) where E : Entity
        {
            if (includeAttributeList == null)
                includeAttributeList = new HashSet<string>(Enumerable.Select(entity.Attributes, x => x.Key));
            includeAttributeList.Remove("createdby");
            includeAttributeList.Remove("createdon");
            includeAttributeList.Remove("createdonbehalfby");
            includeAttributeList.Remove("modifiedby");
            includeAttributeList.Remove("modifiedon");
            includeAttributeList.Remove("modifiedonbehalfby");
            Entity entity1 = new Entity(entity.LogicalName);

            using (IEnumerator<KeyValuePair<string, object>> enumerator = entity.Attributes.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, object> current = enumerator.Current;
                    if (includeAttributeList.Contains(current.Key))
                        (entity1.Attributes).Add(new KeyValuePair<string, object>(current.Key, current.Value));
                }
            }
            return entity1;
        }

        public static Entity AdditiveCopy<E>(this E entity, Entity targetEntity, HashSet<string> includeAttributeList = null, HashSet<string> excludeAttributeList = null) where E : Entity
        {
            if (includeAttributeList == null)
                includeAttributeList = new HashSet<string>(entity.Attributes.Select(x => x.Key));
            includeAttributeList.Remove("createdby");
            includeAttributeList.Remove("createdon");
            includeAttributeList.Remove("createdonbehalfby");
            includeAttributeList.Remove("modifiedby");
            includeAttributeList.Remove("modifiedon");
            includeAttributeList.Remove("modifiedonbehalfby");

            if (excludeAttributeList != null)
            {
                foreach (var iten in excludeAttributeList)
                {
                    includeAttributeList.Remove(iten);
                }
            }

            //Entity entity1 = new Entity(entity.LogicalName);
            using (IEnumerator<KeyValuePair<string, object>> enumerator = entity.Attributes.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, object> current = enumerator.Current;
                    if (includeAttributeList.Contains(current.Key))
                    {
                        if (current.Value != null)
                        {
                            var s = current.Value as string;
                            if (s != null)
                            {
                                if (string.IsNullOrWhiteSpace(s))
                                {
                                    continue;
                                }
                            }
                            targetEntity.Attributes[current.Key] = current.Value;
                        }
                    }
                }
            }
            return targetEntity;
        }
    }
}
