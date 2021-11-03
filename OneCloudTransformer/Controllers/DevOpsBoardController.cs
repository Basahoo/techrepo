using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OneCloudTransformer.Controllers
{
    public class DevOpsBoardController : Controller
    {
        public IActionResult DevOpsBoard()
        {
            return View();
        }
    }
}
