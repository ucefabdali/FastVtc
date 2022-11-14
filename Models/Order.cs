using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastVtc.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public int TravelersNumber { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PaymentMethod { get; set; }
        public string EstimatedDistance { get; set; }
        public string EstimatedDuration { get; set; }
        public string EstimatedCost { get; set; }
        public bool OrderProcessed { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}