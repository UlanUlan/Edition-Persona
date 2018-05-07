using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Zadanie3
{
    public enum Position { geograg, himik, biolog, filolof }
    public class Teacher : Persona
    {
        public Teacher(string _surName, DateTime _DateOfBirth, Faculty _faculty, Position position, int experience) : base(_surName, _DateOfBirth, _faculty)
        {
        }

        public Position position { get; set; }
        public int experience { get; set; }

        public override void print()
        {
            Console.WriteLine("Surname: {0}. Date of birth: {1}. Faculty '{2}'. Position '{3}'. Experiense '4'.", surName, DateOfBirth, faculty, position, experience);
        }
        public override int returnAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
