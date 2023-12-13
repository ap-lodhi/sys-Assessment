using Final_Assessment.Dal;
using Final_Assessment.interfacess;
using Final_Assessment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.Controllers
{
    public class DashboardController : Controller
    {

        CompanyInterface com = new Company();
        public IActionResult Index()
        {
            ViewBag.sess = HttpContext.Session.GetString("text");
            return View();
        }


        public IActionResult AddCompany(int id )
        {

            ViewBag.sess = HttpContext.Session.GetString("text");
            var Country = com.getCountryList();
            ViewBag.roleDes = new SelectList(Country, "CountryId", "CountryName");

            var state = com.getStateList( id);
            ViewBag.Statelist = new SelectList(state, "StateId", "StateName");

          
                var City = com.getCityList(id);

            ViewBag.roleDes2 = new SelectList(City, "CityId", "CityName");

            return View();
        }

        [HttpPost]
        public JsonResult statefilter(int  id)
        {
            var state = com.getStateList(id);
            return Json(state);
            
        }
        [HttpPost]
        public JsonResult cityfilter(int id)
        {
            var City = com.getCityList(id);
            return Json(City); 
        }


        public JsonResult saveCompany(CompanyModel C)

        {
            ViewBag.sess = HttpContext.Session.GetString("text");
            ResponseModel result = new ResponseModel();

            result =com.saveCompany(C);

            return Json(result);

        }

        public IActionResult GetCompanyList()

        {

            ViewBag.sess = HttpContext.Session.GetString("text");
            List<CompanyModel> result = com.getComapnyList();
            return View(result);
        }

        public IActionResult EditCompany(int id)
        {


            ViewBag.sess = HttpContext.Session.GetString("text");
            var Country = com.getCountryList();
            ViewBag.roleDes = new SelectList(Country, "CountryId", "CountryName");

            var state = com.getStateList(id);
            ViewBag.Statelist = new SelectList(state, "StateId", "StateName");


            var City = com.getCityList(id);
           ViewBag.roleDes2 = new SelectList(City, "CityId", "CityName");

            var s =  com.editCompany(id);
            return View(s);
        }


        public JsonResult UpdateCompany(CompanyModel C)

         {
            return Json(com.updateCompany(C));
        }
    }
}
