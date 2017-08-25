using System;

namespace Lineage.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public DateTime StartDate { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }

    }
}