using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Text;
using System.Xml.Serialization;

namespace WebMvc.Helpers
{
    public static class RedirectHelper
    {
        public static ContentResult PostRedirect(string url, params object[] data)
        {
            StringBuilder s = new();
            s.Append("<html>");
            s.AppendFormat("<body onload='document.forms[\"form\"].submit()'>");
            s.AppendFormat("<form name='form' action='{0}' method='post'>", url);
            foreach (var item in data)
            {
                NameValueCollection nameValueCollection = item.ToNameValueCollection();
                foreach (string key in nameValueCollection)
                {
                    s.AppendFormat("<input type='hidden' name='{0}' value='{1}' />", key, nameValueCollection[key]);
                }
            }
            s.Append("</form></body></html>");
            return new()
            {
                ContentType = "text/html",
                Content = s.ToString()
            };
        }

        public static ContentResult PostRedirectXml(string url, object data)
        {
            StringBuilder s = new();
            XmlSerializer serializer = new(data.GetType());
            string xml = "";
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, data);
                xml = writer.ToString();
            }
            s.Append("<html>");
            s.AppendFormat("<body onload='document.forms[\"form\"].submit()'>");
            s.AppendFormat("<form name='form' action='{0}' method='post' enctype=\"text/xml\">", url);
            s.AppendFormat("<textarea style='visibility: hidden;' name='xmlData'>{0}</textarea>", xml);
            s.Append("</form></body></html>");
            return new()
            {
                ContentType = "text/html",
                Content = s.ToString()
            };
        }
    }
}
