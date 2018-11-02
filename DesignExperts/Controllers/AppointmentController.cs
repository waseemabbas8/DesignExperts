﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignExperts.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignExperts.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly dbDesignExpertsContext ORM;

        public AppointmentController(dbDesignExpertsContext _ORM)
        {
            this.ORM = _ORM;
        }

        public IActionResult AllClients()
        {
            IList<Client> clients = ORM.Client.ToList<Client>();
            return View(clients);
        }

        public string GetAllClients()
        {
            string result = "";
            IList<Client> clients = ORM.Client.ToList<Client>();
            return result;
        }

        [HttpPost]
        public IActionResult AddClient(Client _Client)
        {
            if (ModelState.IsValid)
            {
                ORM.Client.Add(_Client);
                ORM.SaveChanges();
                return Json("Done");
            }
            else
            {
                return Json("Error");
            }
           
        }
    }
}