﻿using System.Collections.Generic;

namespace CarRentalApp.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}