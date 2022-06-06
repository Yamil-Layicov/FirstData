using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public bool IsFeatured { get; set; }
        public List<PlanFeature> PlanFeatures { get; set; }
    }
}   
