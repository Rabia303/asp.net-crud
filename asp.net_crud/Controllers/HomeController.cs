using asp.net_crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.net_crud.Controllers
{
	public class HomeController : Controller
	{
		private readonly AbcCompDBcontext db;

        public HomeController(AbcCompDBcontext db)
        {
            this.db = db;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult insert()
		{
			return View();
		}
		[HttpPost]
        public IActionResult insert(Employee add)
        {
			db.Employees.Add(add);
			db.SaveChanges();
            return RedirectToAction("Index");
        }

      
        public IActionResult delete(int e_Id)
        {
            var find = db.Employees.Find(e_Id);
            db.Employees.Remove(find);
            db.SaveChanges();
            return RedirectToAction("fetch");
        }
        public IActionResult edit(int e_Id)
        {
           var find= db.Employees.Find(e_Id);

            return View(find);
        }
        [HttpPost]
        public IActionResult edit(Employee edit)
        {
            db.Employees.Update(edit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult fetch()
        {
            return View(db.Employees.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
