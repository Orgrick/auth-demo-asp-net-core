using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Resource.Api.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Titile { get; set; }

        public decimal Price { get; set; }

    }
}
