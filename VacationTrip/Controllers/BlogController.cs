using Microsoft.AspNetCore.Mvc;
using VacationTrip.Models.Siniflar;




namespace VacationTrip.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context c;
        public BlogController(Context c) { this.c = c; }
		BlogYorum by = new BlogYorum();
		public IActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            by.Deger1=c.Blogs.ToList();
            by.Deger3 =c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        public IActionResult BlogDetay(int id)
        {

            //var blogbul=c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id) 
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
       public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView("Index");
        }
    }
}
