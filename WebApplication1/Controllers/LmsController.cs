using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("Lms")]
    public class LmsController : ControllerBase
    {
        [HttpPut]
        [Route("homeworks")]
        public void GetHomework(long id)
        {

        }
    }
}
