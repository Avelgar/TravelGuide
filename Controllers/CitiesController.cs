﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TravelGuide.Data;
using TravelGuide.Models;

namespace TravelGuide.Controllers
{
    public class CitiesController : Controller
    {
        private readonly TravelGuideDbContext _context;

        public CitiesController(TravelGuideDbContext context)
        {
            _context = context;
        }

        // GET: Cities
        public async Task<IActionResult> Index(string searchString)
        {
            var cities = from c in _context.Cities
                         select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                cities = cities.Where(c => c.Name.Contains(searchString));
            }

            return View(await cities.ToListAsync());
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .Include(c => c.Attractions)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }
    }
}
