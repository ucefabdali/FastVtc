using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using FastVtc.Configurations;
using FastVtc.Models;
using FastVtc.Services.Interfaces;
using FireSharp;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace FastVtc.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly FirebaseClient _firebaseClient;
        private readonly IViewToStringRenderer _viewRenderer;
        private readonly IMailerService _mailerService;
        public OrderService(IServiceProvider serviceProvider)
        {
            var firebaseSettings = serviceProvider.GetRequiredService<IOptions<FirebaseConfig>>().Value;
            this._firebaseClient = new FirebaseClient(new FireSharp.Config.FirebaseConfig
            {
                AuthSecret = firebaseSettings.Key,
                BasePath = firebaseSettings.Path
            });
            this._viewRenderer = serviceProvider.GetRequiredService<IViewToStringRenderer>();
            this._mailerService = serviceProvider.GetRequiredService<IMailerService>();
        }

        public async Task CreateOrder(Order order)
        {
            order.OrderProcessed = false;
            order.CreatedAt = DateTime.Now;
            order.IsDeleted = false;
            this._firebaseClient.Push("/orders/", order);

            var notificationTemplate = await this._viewRenderer.RenderToStringAsync(
                "~/Views/Mailer/NotificationTemplate.cshtml", order, CultureInfo.CurrentCulture);
            await _mailerService.SendEmailAsync("vtcfast33@gmail.com", "Fast VTC [Nouvelle réservation]", notificationTemplate);

            var welcomeTemplate = await this._viewRenderer.RenderToStringAsync(
                "~/Views/Mailer/NotificationTemplate.cshtml", order, CultureInfo.CurrentCulture);
            await _mailerService.SendEmailAsync(order.Email, "Fast VTC [Confirmation de votre réservation]", welcomeTemplate);

        }

        
    }
}
