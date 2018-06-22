namespace Presentation.Controllers
{
    using System.Web.Mvc;

    public class RedirectionerController : Controller
    {
        [HttpGet, Route("")]
        public ActionResult Redirect() => RedirectToActionPermanent("DocumentationPage", "Documentation");
    }
}
