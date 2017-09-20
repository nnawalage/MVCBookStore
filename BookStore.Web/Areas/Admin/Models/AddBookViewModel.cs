using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Web.Areas.Admin.ViewModels
{
    public class AddBookViewModel
    {
        [DisplayName("Book Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [DisplayName("ISBN")]
        [RegularExpression("[0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*[-| ][0-9]*",ErrorMessage ="ISBN Must be in correct format")]
        [Required(ErrorMessage = "ISBN is Required")]
        public string Isbn { get; set; }

        [DisplayName("Price")]
       
        [Required(ErrorMessage = "Price is Required")]

        public decimal Price { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "Category is Required")]
        public int CategoryId { get; set; }

       
        public SelectList CategoryList { get; set; }

        public bool P { get; set; }
    }
}