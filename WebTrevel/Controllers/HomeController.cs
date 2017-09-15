using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTrevel.Models;

namespace WebTrevel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string token = System.Configuration.ConfigurationManager.AppSettings["travel_token"];
            string marker = System.Configuration.ConfigurationManager.AppSettings["travel_marker"];
            return View(new TravelInfoModel
            {
                Marker = marker,
                Token = token
            });
        }
    }
}