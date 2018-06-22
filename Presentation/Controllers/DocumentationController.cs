namespace Presentation.Controllers
{
    using System.Web.Mvc;

    public class DocumentationController : Controller
    {
        [HttpGet, Route("api")]
        public ActionResult DocumentationPage() => View("APIDocumentation");
    }
}
