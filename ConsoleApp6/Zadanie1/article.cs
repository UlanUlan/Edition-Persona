using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie1
{
    public class Article : Edition
    {
        public Article(string name, string author, DateTime _dateOfEdition, string _nameOfJournal, int _number) : base(name, author)
        {
            dateOfEdition = _dateOfEdition;
            nameOfJournal = _nameOfJournal;
            number = _number;
        }
        public DateTime dateOfEdition { get; set; }
        public string nameOfJournal { get; set; }
        public int number { get; set; }

        public override void print()
        {
            Console.WriteLine("Name: '{0}'.  Author: {1}. DateOfEdition: {2}. NameOfJournal: '{3}'. Number: {4}", name, author, dateOfEdition, nameOfJournal, number);
        }
    }
}
