using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NuGet.Protocol.Plugins;
using VacationTrip.Models.Siniflar;

namespace VacationTrip.Controllers
{
    public class AdminController : Controller
    {
        private readonly Context c;
        public AdminController(Context c)
        {
            this.c = c;
        }
        public IActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BlogSil(int id)
        {
            var b= c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges(); 
            return RedirectToAction("Index");
        }
        public IActionResult BlogGetir (int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public IActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik=b.Baslik;
            blg.BlogImage=b.BlogImage;
            blg.Tarih=b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
         
    }
}
