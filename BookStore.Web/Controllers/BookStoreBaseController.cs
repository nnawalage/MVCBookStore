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
        
    }
}