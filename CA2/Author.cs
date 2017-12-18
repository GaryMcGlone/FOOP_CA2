using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Author : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Book[] Books { get; set; }

        public int CompareTo(object obj)
        {
            Author temp = (Author)obj;
            return String.Compare(this.LastName, temp.LastName);
        }
        public override string ToString()
        {
            return FirstName + ", " + LastName;
        }
    }
}
