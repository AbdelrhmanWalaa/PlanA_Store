using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlanA_Store.Controllers
{
    public class ElectronicStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}