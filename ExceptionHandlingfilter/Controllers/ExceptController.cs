using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandlingfilter.Controllers
{
    public class ExceptController : Controller
    {
        // GET: Except
        [TestExceptionFliter]
        public ActionResult Index()
        {
            try
            {
                throw new Exception("");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return View();
        }
        [CustomResult]
        public ActionResult res()
        {
            return View();
        }
    }
}