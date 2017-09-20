using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.MockService.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}
