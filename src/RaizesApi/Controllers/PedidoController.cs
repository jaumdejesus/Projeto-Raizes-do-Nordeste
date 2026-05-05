using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Services;
using System.Net;

namespace RaizesApi.Controllers
{
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        [Route("pedido")]
        public IActionResult Pedido([FromBody] PedidoDTO pedido)
        {
            return new JsonResult(new
            {
                
            });
        }
    }
}
