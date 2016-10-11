using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo10071.Models;

namespace Demo10071.Controllers
{
    public class HomeController : Controller
    {
        //Fejkar koppling till en DB för Experiences

        private List<Experience> MyExperienceList;

        public HomeController()
        {
            MyExperienceList = new List<Experience>();
            MyExperienceList.Add(new Experience() { Title = "Målare", Description = "Målade farfars hus", Period = "2016" });
            MyExperienceList.Add(new Experience() { Title = "Tryckare", Description = "Tryckte tidningar", Period = "2015-" });
            MyExperienceList.Add(new Experience() { Title = "Försäljare", Description = "Sålde postkodlotter", Period = "2015" });
        }

        //===========================================

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(MyExperienceList);
        }
    }
}