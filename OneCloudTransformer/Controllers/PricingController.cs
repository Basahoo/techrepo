using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OneCloudTransformer.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
