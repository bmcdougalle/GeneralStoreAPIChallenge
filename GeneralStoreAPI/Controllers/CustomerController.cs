using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using GeneralStoreAPI.Models;

namespace GeneralStoreAPI.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}