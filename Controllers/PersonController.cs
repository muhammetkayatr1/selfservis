using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfServisUI.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonLogin()
        {
            return View();
        }

        public IActionResult PersonInfo()
        {
            return View();
        }

        public IActionResult PersontPasswordStepOne()
        {
            return View();
        }

        public IActionResult PersonPasswordStepTwo()
        {
            return View();
        }

        public IActionResult PersonPasswordStepThree()
        {
            return View();
        }
    }
}
