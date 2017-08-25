using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionHandlingfilter
{
    public class TestExceptionFliter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            //throw new NotImplementedException();
            if(!filterContext.ExceptionHandled)
            {
                filterContext.Result = new RedirectResult("~/Htmlpage2.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}