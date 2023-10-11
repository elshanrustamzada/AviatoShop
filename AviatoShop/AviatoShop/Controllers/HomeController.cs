using AviatoShop.DAL;
using AviatoShop.Models;
using AviatoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AviatoShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new()
            {
                Sliders = await _db.Sliders.ToListAsync()
            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return View();
        }

      
    }
}