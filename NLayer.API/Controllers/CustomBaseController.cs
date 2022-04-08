using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTO;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]  //EndPoint olmadığını belirmek için kullanıldı. kullanılmadığında get mi post mu bilinmediğinden hata fırlatıyor.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            
                return new ObjectResult(response)
                {
                    StatusCode = response.StatusCode
                };
        }
    }
}
