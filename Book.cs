using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Created by Barış Algül(baris@barisalgul.com)
/// </summary>

namespace BookListWebApi.Models
{
    public class Book
    {
        public int Book_ID { get; set; }
        public string Book_Name { get; set; }
        public string Book_Writer { get; set; }
        public double Book_Price { get; set; }
    }
}