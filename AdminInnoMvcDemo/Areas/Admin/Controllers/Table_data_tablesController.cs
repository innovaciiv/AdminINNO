using AdminInnoMvcDemo.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminInnoMvcDemo.Areas.Admin.Controllers
{
    public class Table_data_tablesController : Controller
    {
        // GET: Admin/Table_data_tables
        public ActionResult Index()
        {
            var model = new DataTableViewModel();
            return View(model.GetList());
        }

        // Scafolds generate List whith datatable (ListDataTable)
        public ActionResult ListDataTable()
        {
            var model = new DataTableViewModel();
            return View(model.GetList());
        }
    }
}