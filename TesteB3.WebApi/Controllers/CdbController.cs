using Microsoft.AspNetCore.Mvc;
using TesteB3.Models;

namespace TesteB3.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CdbController : Controller
    {

        [HttpPost]
        public CdbModel Post()
        {
            return new CdbModel(10000, 0.9, 108, 2 );
        }
    }
}
