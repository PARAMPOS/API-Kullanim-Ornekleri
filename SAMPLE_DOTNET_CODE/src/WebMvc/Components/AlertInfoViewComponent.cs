using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Components
{
    public class AlertInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
            return View<string>(message);
        }
    }
}