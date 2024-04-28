using HellowWebEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellowWebEmpty.Controllesrs
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HelloMessage msg = new HelloMessage()
            {
                Message = "welcome to asp.net MVC"
            };

            ViewBag.Noti = "Input message and click";

            return View(msg);
        }

        //Post처리
        [HttpPost]
        public IActionResult Index(HelloMessage obj)
        {
            ViewBag.Noti = "Message Changed";
            return View(obj);
        }
    }
}
