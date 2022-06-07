using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.OrderBy(x => x.Order).ToList();
            List<Feature> features = _context.Features.ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = sliders,
                Features =features,
                
            };

            return View(homeVM);
        }
    }
}
