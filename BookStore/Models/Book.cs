using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        //ID book
        public int id { get; set; }
        //Book name
        public string Name { get; set; }
        //Author book
        public string Author { get; set; }
        //Price
        public int Price { get; set; }
    }
}