using BookStore.MockService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Controllers
{
    public class BookStoreBaseController : Controller
    {

        private BookStoreService bookStoreService;

        public BookStoreService BookStoreService
        {
            get
            {
                bookStoreService = bookStoreService ?? new BookStoreService();
                return bookStoreService;
            }
        }




        /// <summary>
        /// On Exception filter
        /// </summary>
        /// <param name="filterContext">exceptionContext</param>
        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    //Log Error
        //    //LogManager.LogError(filterContext.Exception, string.Empty);

        //    //if Ajax request
        //    if (filterContext.RequestContext.HttpContext.Request.IsAjaxRequest())
        //    {
        //        //filterContext.ExceptionHandled = true;
        //        JsonResult jsonResult = new JsonResult();
        //        jsonResult.Data = new
        //        {
        //            ErrorCode = filterContext.HttpContext.Response.Status,
        //            Message = "errorMessage",
        //        };
        //        jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        //        filterContext.Result = jsonResult;
        //    }
        //    else
        //    {
        //        filterContext.ExceptionHandled = true;
        //        //set view model
        //        var viewModel = new 
        //        {
        //            ErrorMessage = "errorMessage",
        //            Title = "Error"
        //        };
        //        //redirect to error page
        //        filterContext.Result = RedirectToAction("LoadError", "User", viewModel);
        //    }
        //}

    }
}