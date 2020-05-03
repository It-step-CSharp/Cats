using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cats.Models;
using Cats.Data;
using Cats.Data.Models;
using System.ComponentModel.DataAnnotations;

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
            if (ModelState.IsValid)
            {
                catService.Edit(cat);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add([Required, MinLength(1)]string catName, [Range(1, 100)]int catAge)
        {
            if (ModelState.IsValid)
            {
                catService.Add(catName, catAge);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            catService.Delete(id);

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
