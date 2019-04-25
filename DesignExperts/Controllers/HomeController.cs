using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesignExperts.Data;

namespace DesignExperts.Controllers
{
    public class HomeController : Controller
    {
        private readonly dbDesignExpertsContext db;

        public HomeController(dbDesignExpertsContext _ORM)
        {
            this.db = _ORM;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(ViewLogin viewLogin)
        {
            User user = db.User.Where(m => m.UserName == viewLogin.UserName && m.Password == viewLogin.Password).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction(nameof(HomeController.Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddUpdateAppointment(int ID = 0)
        {
            if (ID != 0)
            {
                return View(db.Appointment.Where(m => m.Id == ID).FirstOrDefault());
            }
            return View(new Appointment());
        }

        [HttpPost]
        public async Task<IActionResult> AddUpdateAppointment(Appointment appointment)
        {
            if (appointment.IsNew)
            {
                await db.Appointment.AddAsync(appointment);
            }
            else
            {
                db.Appointment.Update(appointment);
            }           
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(HomeController.AddUpdateAppointment));
        }

        [HttpGet]
        public IActionResult ViewAppointment()
        {                       
            return View(db.Appointment.ToList());
        }




        [HttpGet]
        public IActionResult AddUpdateGeneralType()
        {
            ViewBag.GeneralTypes = db.GeneralType.ToList();
            return View();
        }

    }
}
