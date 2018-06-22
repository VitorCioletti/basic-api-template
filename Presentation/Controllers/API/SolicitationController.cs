namespace Presentation.Controllers
{
    using Domain.DependencyInjection;
    using System.Collections.Generic;
    using System.Web.Http;

    public class SolicitationController : ApiController
    {
        [HttpGet, Route("api/solicitation/test")]
        public IEnumerable<string> GetTestSolicitation() => Dependencies.SolicitationDAO.GetTestSolicitation();
    }
}
