using BookStore.MockService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.MockService
{
    public class BookStoreService
    {
        public bool SaveBook(Book book)
        {
            //Save book here
            return true;
        }

        public IList<Category> GetCategoryList()
        {
            return new List<Category>()
            {
                new Category() { Id=1, Name="Fiction"},
                new Category() { Id=1, Name="Science"}
            };
        }
    }
}
