using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie1
{
    public abstract class Edition
    {
        public string name { get; set; }
        public string author { get; set; }
        public Edition(string _name, string _author)
        {
            name = _name;
            author = _author;
        }
        public abstract void print();
        
    }

}

