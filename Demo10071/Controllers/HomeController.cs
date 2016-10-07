using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Adding a class up here fakes a connection, or more like establishing one.
using Demo10071.Models;

namespace Demo10071.Controllers
{
    public class HomeController : Controller
    {
        //Fakes a connection to the Database for experiences
        List<Experience>

            private List<Experience> MyExperienceList;
            public HomeController()
        {
            MyExperienceList = new List<Experience>();
            MyExperienceList.Add(new Experience() { Title = "", Description = "", Period = "" });
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}