using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Components
{
    public class AlertDangerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
            return View<string>(message);
        }
    }
}