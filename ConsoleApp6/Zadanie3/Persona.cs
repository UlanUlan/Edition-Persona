using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie3
{
    public enum Faculty { GeneralMedical, Dental, pharmacy, PublicHealth, PreventiveMedical}
    public abstract class Persona
    {
        public string surName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Faculty faculty { get; set; }
        public Persona(string _surName, DateTime _DateOfBirth, Faculty _faculty)
        {
            surName = _surName;
            DateOfBirth = _DateOfBirth;
            faculty = _faculty;
        }
        public abstract void print();
        public abstract int returnAge();
        
    }
}
