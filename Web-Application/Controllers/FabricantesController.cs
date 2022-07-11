using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Application.Context;

namespace Web_Application.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContext context = new EFContext();
        
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}