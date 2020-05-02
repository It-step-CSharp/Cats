using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cats.Models;
using Cats.Data;
using Cats.Data.Models;

namespace Cats.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICatService catService;

        public HomeController(ICatService catService)
        {
            this.catService = catService;
        }

        public IActionResult Index()
        {
            var cats = catService.GetAll();

            return View(cats);
        }

        [HttpGet]
        [Route("Home/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = catService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveEdit(Cat cat)
        {
            catService.Edit(cat);

            return RedirectToAction("Index");
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
