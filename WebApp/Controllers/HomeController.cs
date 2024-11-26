using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.DataAccess;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController(ProductDbContext _sql) : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View(_sql.Products.ToList());
        }
        public IActionResult Pages()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            _sql.Products.Add(p);
            _sql.SaveChanges();
            return RedirectToAction(nameof(Shop));
        }

        public IActionResult Delete(int id,Product p)
        {
            if (id==null) return BadRequest();
            //var data = _sql.Products.Find(p =>p.Id==id);

            if (data is null)
            {
                _sql.Products.Remove(data);
                _sql.SaveChanges();
            }
            return RedirectToAction(nameof(Shop));

        }

        public IActionResult Update()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Update()
        //{
        //    return View();
        //}



    }
}
