using Microsoft.AspNetCore.Mvc;
using TesteB3.Models;

namespace TesteB3.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CdbController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] CdbDto cdbDto)
        {
            try
            {
                var result = new CdbModel(cdbDto.ValorInicial, 0.9, 108, cdbDto.Meses);
                return Ok(new Result()
                { 
                    Success = true,
                    Message = "",
                    Data = result
                });
            }
            catch (Exception ex)
            {

                return BadRequest(new Result() 
                { 
                    Success = false,
                    Message = ex.Message,
                    Data = null 
                });
            }
        }
            
    }
}
