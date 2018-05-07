using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie1
{
    public class Book : Edition
    {
        public Book(string name, string author, DateTime _dateOfEdition, string _publishing) : base(name, author)
        {
            dateOfEdition = _dateOfEdition;
            publishing = _publishing;
        }
        public DateTime dateOfEdition { get; set; }
        public string publishing { get; set; }


        public override void print()
        {
            Console.WriteLine("Name: '{0}'.  Author: {1}. DateOfEdition: {2}. Publishing: {3}", name, author, dateOfEdition, publishing);
        }
    }
}
