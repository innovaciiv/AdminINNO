using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AdminInnoMvcDemo.Areas.Admin.Controllers
{
    public class Form_AdvancedController : Controller
    {
        // GET: Admin/Form_Advanced
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ElementOutocomplite(string id)
        {
            var element = new[] { new { id = 1, name = "name1" }, new { id = 2, name = "name2" }, new { id = 3, name = "name3" } };
            return Json(element);
        }
    }
}