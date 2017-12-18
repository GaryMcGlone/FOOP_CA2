using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Author : IComparable
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //This is a collection of book objects
        //inside this collection there is three different book arrays
        public Book[] Books { get; set; }

        //IComparable interface which will allow you to use Array.Sort
        //Using it to sort by an Authors last name
        public int CompareTo(object obj)
        {
            Author temp = (Author)obj;
            return String.Compare(this.LastName, temp.LastName);
        }
        //ToString Method which returns the details of each author
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}
