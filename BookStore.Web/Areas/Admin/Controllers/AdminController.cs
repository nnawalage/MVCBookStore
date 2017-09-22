using BookStore.MockService.Entities;
using BookStore.Web.Areas.Admin.ViewModels;
using BookStore.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Areas.Admin.Controllers
{
    //[RoutePrefix("BookStore")]
    //[RouteArea("Admin")]
    //[Authorize]
    //[Authorize(Users ="ndn1@tiqri.com")]
    public class AdminController : BookStoreBaseController
    {

        //If only route prefix is used= /BookStore/AddBook
        // GET: Admin/Admin
        //[Route]
        //[OverrideAuthorization]
        //[Authorize(Users = "ndn@tiqri.com")]
       // [Route("AddNewBook")]
        public ActionResult AddBook()
        {
            //ViewBag.Title = "Add Book";
            //ViewData["Message"] = "You can add book from here";
            //ViewData.Add("key", 5);
            //ViewData.Add(new KeyValuePair<string, object>("newKey",6));

            var categoryList = BookStoreService.GetCategoryList();

            AddBookViewModel viewModel = new AddBookViewModel()
            {
                CategoryList = new SelectList(categoryList, "Id", "Name", 0)
            };

            return View(viewModel);
            //return View("~/Areas/Admin/Views/Admin/AddBook.cshtml",viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBook(AddBookViewModel model)
        {
            var name = Request["Name"];
            if (ModelState.IsValid)
            {
                Book book = new Book()
                {
                    Name = model.Name,
                    Isbn = model.Isbn,
                    Price = model.Price,
                    CategoryId = model.CategoryId,
                    CreatedDate = DateTime.Now,
                    CreatedBy = HttpContext.User.Identity.Name
                };

                BookStoreService.SaveBook(book);

                //TempData["message"] = "Hello from Add Book";

                return RedirectToAction("Index");
            }
            var categoryList = BookStoreService.GetCategoryList();
            model.CategoryList = new SelectList(categoryList, "Id", "Name", model.CategoryId);
            //ModelState.AddModelError("", "Some other error such as Book Name already exist");
            return View(model);
        }

        public ActionResult Index()
        {
            if (TempData.ContainsKey("message"))
            {
                ViewBag.Message = TempData["message"];
            }
            return View();
        }
    }
}