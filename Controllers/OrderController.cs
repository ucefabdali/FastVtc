using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastVtc.Models;
using FastVtc.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FastVtc.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IServiceProvider _serviceProvider;
        public OrderController(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Order order)
        {
            try
            {
                var service = this._serviceProvider.GetRequiredService<IOrderService>();
                await service.CreateOrder(order);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
