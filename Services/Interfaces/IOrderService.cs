using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastVtc.Models;

namespace FastVtc.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(Order order);
    }
}
