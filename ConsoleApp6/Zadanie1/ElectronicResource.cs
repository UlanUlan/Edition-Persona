using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie1
{
    public class ElectronicResource : Edition
    {
        public ElectronicResource(string name, string author, string _reference, string _annotation) : base(name, author)
        {
            reference = _reference;
            annotation = _annotation;
        }
        public string name { get; set; }
        public string author { get; set; }
        public string reference { get; set; }
        public string annotation { get; set; }

        public override void print()
        {
            Console.WriteLine("Name: '{0}'.  Author: {1}. Reference: {2}. Annotation: {3}", name, author, reference, annotation);
        }
    }
}
