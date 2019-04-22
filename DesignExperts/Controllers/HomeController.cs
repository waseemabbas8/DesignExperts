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
        private readonly dbDesignExpertsContext ORM;

        public HomeController(dbDesignExpertsContext _ORM)
        {
            this.ORM = _ORM;
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
            User user = ORM.User.Where(m => m.UserName == viewLogin.UserName && m.Password == viewLogin.Password).FirstOrDefault();
            if (user != null)
            {
                return RedirectToAction(nameof(HomeController.Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddUpdateAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUpdateAppointment(Appointment appointment)
        {
            return View();
        }


    }
}
