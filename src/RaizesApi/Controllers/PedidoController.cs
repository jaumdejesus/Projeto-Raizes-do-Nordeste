using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Services;
using System.Net;
using AutoMapper;
using Application.DTOs;

namespace RaizesApi.Controllers
{
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpPost]
        [Route("pedido")]
        public IActionResult Pedido([FromBody] PedidoRequestDTO pedido)
        {
            
            return new JsonResult(new
            {
                
            });
        }
    }
}
