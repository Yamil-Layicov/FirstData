using BootStrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.ViewModels
{
    public class PricingViewModel
    {
        public List<Plan> Plans { get; set; }
        public List<FeatureItem> FeatureItems { get; set; }
    }
}
