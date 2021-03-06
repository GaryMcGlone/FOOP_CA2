﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Book
    {
        //Properties
        public string Title { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }

        //ToString method which returns the book details
        public override string ToString()
        {
            return Title + ", " + Pages + " pages - €" + Price;
        }
    }
}
