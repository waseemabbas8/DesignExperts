using System;
using System.Linq;
using System.Threading.Tasks;
using DesignExperts.Data;
using DesignExperts.Models;
using DesignExperts.Resources;
using Microsoft.AspNetCore.Mvc;

namespace DesignExperts.Controllers
{
    public class HRController : Controller
    {
        private readonly dbDesignExpertsContext Db;
        public HRController(dbDesignExpertsContext db)
        {
            this.Db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUpdateMember()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<JsonResult> AddUpdateMember(Member member)
        {
            return AddObjectToDb(member);
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
                    Db.Add(obj);
                    await Db.SaveChangesAsync();
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