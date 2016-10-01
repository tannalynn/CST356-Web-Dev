using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1.Models;

namespace lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
	        var p = new Person
	        {
		        name = "person mcpersonface",
		        alignment = "chaotic neutral"
	        };

            return View(p);
        }
    }
}