using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAssignment2.Models;

namespace WebAppAssignment2.Controllers
{
    public class DetailController : Controller
    {
        /// <summary>
        /// Default Action result
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            SportsData objPlayer = new SportsData();
            var player = objPlayer.Getata();
            ViewData.Model = player;

            return View();
        }
    }
}