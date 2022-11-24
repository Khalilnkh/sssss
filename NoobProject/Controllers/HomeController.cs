using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoobProject.DAL;
using NoobProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoobProject.ViewModels.HomeVM;

namespace NoobProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppdbNoob _context;
        public HomeController(AppdbNoob context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.Where(s=>s.IsDeleted==false).ToListAsync();

            HomeViewModel homeViewModel = new HomeViewModel
            {
                sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
            categories = await _context.categories.Where( c => c.IsDeleted == false  ).ToListAsync(),
            products= await _context.products.Where(p=>p.IsDeleted==false).ToListAsync(),

            };
            return View(homeViewModel);
        }
    }
}
