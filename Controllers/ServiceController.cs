using BootStrap.DAL;
using BootStrap.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootStrap.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {   
            //List<service> services = _context.Services.ToList();

            return View(_context.Services.ToList()); 
        }   
    }
}
