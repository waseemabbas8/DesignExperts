using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignExperts.Models;
using DesignExperts.Resources;
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
            IList<Client> clients=null;
            try
            {
                clients = ORM.Client.ToList<Client>();
            }
            catch
            {
                ViewBag.Message = Constants.DB_CONNECTION_ERROR;
            }
            return View(clients);
        }

        public string GetAllClients()
        {
            string result = "";
            IList<Client> clients = ORM.Client.ToList<Client>();
            return result;
        }

        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClient(Client client)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    client.CreatedDate = DateTime.Now;
                    client.CreatedBy = "WASEEM ABBAS";
                    ORM.Client.Add(client);
                    await ORM.SaveChangesAsync();
                    return Json(Constants.DB_CRUD_SUCCESS);
                }
                catch
                {
                    return Json(Constants.DB_CRUD_ERROR);
                }
            }

            return Json(Constants.DB_CRUD_ERROR);
        }

        public IActionResult CreateAppointment()
        {
            return View();
        }

        public IActionResult AllAppointments()
        {
            return View();
        }
    }
}