using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Xml.Serialization;

namespace WebMvc.ModelBinders
{
    public class FormDataXmlBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string xml = bindingContext.HttpContext.Request.Form["xmlData"];
            XmlSerializer serializer = new(bindingContext.ModelType);
            using (var reader = new StringReader(xml))
            {
                bindingContext.Result = ModelBindingResult.Success(serializer.Deserialize(reader));
            }
            return Task.CompletedTask;
        }
    }
}
