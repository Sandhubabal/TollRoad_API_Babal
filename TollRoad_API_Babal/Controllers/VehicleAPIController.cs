using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TollRoad_API_Babal.Controllers
{
    public class VehicleAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
