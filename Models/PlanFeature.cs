using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.Models
{
    public class PlanFeature
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public Plan plan { get; set; }
        public int FeatureItemId { get; set; }
        public FeatureItem FeatureItem { get; set; }
    }
}
