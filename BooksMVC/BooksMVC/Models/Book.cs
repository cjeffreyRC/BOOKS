using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksMVC.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}