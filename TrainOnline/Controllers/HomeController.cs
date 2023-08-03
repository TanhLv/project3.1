using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrainOnline.Data;
using TrainOnline.DTO;
using TrainOnline.Models;

namespace TrainOnline.Controllers
{
    public class HomeController : BaseeController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roManager;
        private readonly ApplicationDbContext _context;

        public HomeController( ApplicationDbContext context ,IHttpContextAccessor contextAccessor, UserManager<CustomUser> userName, RoleManager<IdentityRole> roleManager) : base(contextAccessor, userName, roleManager)
        {
            _context = context;
        }

        public async Task<IActionResult> SeedingRole()
        {
            var dbSeedRole = new DbSeedRole(_roManager);
            await dbSeedRole.RoleData();
            return Ok("Seed Role Thành Công");
        }

        public  IActionResult Index() //Chon thong tin ngay di, noi den
        {
            return View();
        }

        public IActionResult CacTauDaTimKiem(DateTime ngayDi,int gaDi, int gaDen)
        {
            //Thuc hien viec tim kiem cac tau phu hop
            //Hien thi ra danh sach tau + nhap thong tin cua KH
            //Khi bam nut dat ve thi goi vao action dat ve
            var query = from _tr in _context.TrainTrips
                        join _t in _context.Trains on _tr.TrainId equals _t.TrainId
                        join _s in _context.Schedules on _tr.ScheduleId equals _s.ScheduleId
                        join _sd in _context.ScheduleDetails on _s.ScheduleId equals _sd.ScheduleId
                        join _ss in _context.Stations on _sd.CurrentStation equals _ss.StationId
                        join _ss1 in _context.Stations on _sd.NextStation equals _ss1.StationId
                        //where _tr.DepartureTime.Date.Equals(ngayDi.Date) && (_sd.CurrentStation == gaDi || _sd.NextStation == gaDen)
                        orderby _t.TrainId ascending, _sd.CurrentStation descending
                        
                        select new HienThiChuyenTauDTO()
                        {
                            TrainTripId = _tr.TrainTripId,
                            TrainId = _t.TrainId,
                            TrainNumber = _t.TrainNumber.Value,
                            TenGaDi = _ss.StationName,
                            TenGaDen = _ss1.StationName,
                            GioDi = _tr.DepartureTime,
                            GioDen = _tr.ArrivalTime
                        }
                        ;

            return View(query.ToList());

        }

        public IActionResult DatVe()//Fill thong tin ve vao parameter
        {
            //Tien hanh dat ve o day
            //Tien hanh save db o day

            return View();
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