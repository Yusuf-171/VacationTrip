using Microsoft.AspNetCore.Mvc;
using VacationTrip.Models.Siniflar;


namespace VacationTrip.Controllers
{
    public class AboutController : Controller
    {
        private readonly Context c;
        public AboutController(Context c)
        {
            this.c = c;
        }
        
        public IActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
