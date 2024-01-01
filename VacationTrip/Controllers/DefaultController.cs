using Microsoft.AspNetCore.Mvc;
using VacationTrip.Models.Siniflar;
namespace VacationTrip.Controllers
{
    public class DefaultController : Controller
    {
		private readonly Context c;
		public DefaultController(Context c) { this.c = c; }
		public IActionResult Index()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }
        public IActionResult About() 
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
    }
    
}
