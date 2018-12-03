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
    public class HRController : Controller
    {
        private readonly dbDesignExpertsContext Db;
        public HRController(dbDesignExpertsContext db)
        {
            this.Db = db;
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

        public IActionResult AllMembers()
        {
            return View(Db.Member.ToList<Member>());
        }

        public string GetMembersList()
        {
            string Result = "";

            IList<Member> members = Db.Member.ToList<Member>();

            foreach (Member member in members)
            {
                Result += 
                    "<div class='col-xl-2 col-lg-3 col-sm-4 col-6'>" +
                        "<div class='contacts__item'>" +
                            "<a href='' class='contacts__img'>" +
                                "<img src='~/Theme/demo/img/contacts/1.jpg' alt=''>" +
                            "</a>" +
                            "<div class='contacts__info'>" +
                                "<strong>Cathy Shelton</strong>" +
                                "<small>cathy.shelton31 @example.com</small>" +
                            "</div>" +
                            "<button class='contacts__btn'>Following</button>" +
                        "</div>" +
                    "</div>";
            }

            return Result;
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