using Final_Assessment.Dal;
using Final_Assessment.interfacess;
using Final_Assessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.Controllers
{
    public class UserController : Controller
    {
        RegisterInterface reg = new Register();
        public IActionResult Index()
        {
            return View();
        }

        //public JsonResult registerUser(RegisterModel objmodel)
        //{

        //    ResponseModel result = new ResponseModel();
        //    result = reg.SignupUser(objmodel);
        //    return Json(result);
        //}

        public JsonResult SignupUser(RegisterModel objmodel) {
            ResponseModel result = new ResponseModel();
            result = reg.SignupUser(objmodel);


            return Json(result);

        }

        [HttpPost]
        public IActionResult loginUser(RegisterModel objmodel)
        {

            ResponseModel result = new ResponseModel();

           result = reg.loginUser(objmodel);

            if (result.status == true)
            {
                HttpContext.Session.SetString("text", objmodel.Name);
                return RedirectToAction("Index", "Dashboard");
            }
            //     else
            //    {
            TempData["error"] = "invalid credential";
            //  return Json(result);
            //  }
            return RedirectToAction("Login", "User");

        }


        public IActionResult Login()
        {

            
            return View();

        }

    }
}
