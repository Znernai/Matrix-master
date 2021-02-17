using Matrix.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix.Controllers
{
    public class profileController : Controller
    {
        public IActionResult Profile()
        {
            profileModel profiledata = new profileModel();
            {
                ViewBag.getname=profiledata.name;
            }
            return View();
        }
    }
}
