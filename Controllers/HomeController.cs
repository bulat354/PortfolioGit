using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataAccess;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyPortfolioDbContext _dbContext; 

        public HomeController(ILogger<HomeController> logger, MyPortfolioDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new MainPageVM()
            {
                MainInfos = await _dbContext.MainInfos.AsNoTracking().ToListAsync(),
                Contacts = await _dbContext.Contacts.AsNoTracking().ToListAsync(),
                Links = await _dbContext.Links.AsNoTracking().ToListAsync(),
                Numbers = await _dbContext.Numbers.AsNoTracking().ToListAsync(),
                PortfolioProjects = await _dbContext.PortfolioProjects.AsNoTracking().ToListAsync(),
                ResumeNodes = await _dbContext.ResumeNodes.AsNoTracking().ToListAsync(),
                Skills = await _dbContext.Skills.AsNoTracking().ToListAsync(),
                Testimonials = await _dbContext.Testimonials.AsNoTracking().ToListAsync()
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}