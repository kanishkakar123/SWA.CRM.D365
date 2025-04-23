using System.Net;
using System.Text.RegularExpressions;

namespace SWA.CRM.D365.Common.Helpers
{
    public static class HelperMethods
    {
        public static string UseRegularExpression(string input)
        {
            var result = Regex.Replace(input, "<.*?>", string.Empty);

            return result;
        }

        public static string UseHtmlDecode(string input)
        {
            var result = UseRegularExpression(input);
            result = WebUtility.HtmlDecode(result);

            return result;
        }
    }
}
