using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrapMade.Models
{
    public class PricingService
    {
        public int Id { get; set; }


        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }


    }
}
