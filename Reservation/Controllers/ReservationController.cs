using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.Controllers
{
    public class ReservationController : Controller
    {

        private readonly ApplicationDbContext _adb;

        public ReservationController(ApplicationDbContext adb)
        {
            _adb = adb;
        }
        public IActionResult Index()
        {
            var list = _adb.Reserva.ToList();
            return View(list);
        }
    }
}