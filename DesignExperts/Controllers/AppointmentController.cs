using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignExperts.Data;
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

        public int GetClientsCount()
        {
            return ORM.Client.ToList<Client>().Count;
        }

        [HttpGet]
        public IActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<JsonResult> AddClient(Client client)
        {
            return AddObjectToDb(client);
        }

        [HttpGet]
        public IActionResult ClientDetail(int id)
        {
            return View();
        }

        public IActionResult CreateAppointment()
        {
            ViewBag.ListOfDirectors = ORM.Member.Where(m=>m.Type.Equals((int)MemberType.Director)).ToList<Member>();
            ViewBag.ListOfClients = ORM.Client.ToList<Client>();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<JsonResult> CreateAppointment(Appointment appointment)
        {
            appointment.Status = (int)AppointmentStatus.Booked;
            return AddObjectToDb(appointment);
        }

        public IActionResult AllAppointments()
        {
            return View(ORM.Appointment.ToList<Appointment>());
        }

        //Method to Add any type of object to db
        private async Task<JsonResult> AddObjectToDb(dynamic obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    obj.CreatedDate = DateTime.Now;
                    obj.CreatedBy = "WASEEM ABBAS";
                    ORM.Add(obj);
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

    }
}