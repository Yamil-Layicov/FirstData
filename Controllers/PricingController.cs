using BootStrap.DAL;
using BootStrap.Models;
using BootStrap.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Plan> plans = _context.Plans.Include(p=>p.PlanFeatures).ToList();

            List<FeatureItem> featureItems = _context.FeatureItems.ToList();


            PricingViewModel pricingViewModel = new PricingViewModel
            {
                Plans = plans,
                FeatureItems = featureItems
            };

            return View(pricingViewModel);
        }
    }
}
