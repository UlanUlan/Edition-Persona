using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie3
{
    public class Student : Persona
    {
        public Student(string _surName, DateTime _DateOfBirth, Faculty _faculty) : base(_surName, _DateOfBirth, _faculty)
        {
        }

        public override void print()
        {
            Console.WriteLine("Surname: {0}. Date of birth: {1}. Faculty '{2}'", surName, DateOfBirth, faculty);
        }
        public override int returnAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
