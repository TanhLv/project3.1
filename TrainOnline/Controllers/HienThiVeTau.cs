using Microsoft.AspNetCore.Mvc;
using TrainOnline.Data;

namespace TrainOnline.Controllers
{
    public class HienThiVeTau : Controller
    {
        public ApplicationDbContext db;
        public HienThiVeTau(ApplicationDbContext db)
        {
            db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
