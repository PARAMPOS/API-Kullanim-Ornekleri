using System.Collections.Specialized;
using System.Reflection;

namespace WebMvc.Helpers
{
    public static class NameValueCollectionConverter
    {
        public static NameValueCollection ToNameValueCollection(this object data)
        {
            NameValueCollection collection = ResolveClassProperties(data);
            return collection;
        }

        private static NameValueCollection ResolveClassProperties(object? data, string prefix = "")
        {
            if (data is null)
                return new();
            PropertyInfo[] properties = data.GetType().GetProperties();
            NameValueCollection collection = new();
            foreach (var property in properties)
            {
                string propertyName = prefix + property.Name;
                if (property.PropertyType != typeof(string) && property.PropertyType != typeof(object) && property.PropertyType.IsClass)
                {
                    try
                    {
                        if (property.PropertyType.IsArray)
                        {
                            short arrayCounter = 0;
                            var array = property.GetValue(data) as object[];
                            foreach (object item in array!)
                                collection.Add(ResolveClassProperties(item!, $"{prefix}{property.Name}[{arrayCounter++}]."));
                        }
                        else
                        {
                            collection.Add(ResolveClassProperties(property.GetValue(data)!, propertyName + "."));
                        }
                    }
                    catch { }

                    continue;
                }
                string? propertyValue = property.GetValue(data)?.ToString();
                collection.Add(propertyName, propertyValue);
            }
            return collection;
        }
    }
}
