using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flarc.PortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public ActionResult<int[]> GetValues() {
            return Ok(new int[] { 1, 2, 3, 4 });
        }
    }
}
