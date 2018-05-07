using ConsoleApp6.Zadanie1;
using ConsoleApp6.Zadanie3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rand = new Random();
            string[] editions = { "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };
            string[] authors = { "Maggie", "Penny", "Saya", "Princess",
                                  "Abby", "Laila", "Sadie", "Olivia",
                                  "Starlight", "Talla" };
            void Zadanie1()
            {
                /*1.	Создать абстрактный класс Издание с методами позволяющим вывести на экран информацию об издании, а также определить является ли данное издание искомым.
            2.	Создать производные классы: Книга (название, фамилия автора, год издания, издательство), Статья (название, фамилия автора, название журнала, его номер и год издания), 
            Электронный ресурс (название, фамилия автора, ссылка, аннотация) со своими методами вывода информации на экран.
            3.	Создать каталог (массив) из n изданий, вывести полную информацию из каталога, а также организовать поиск изданий по фамилии автора*/

                List<Edition> Ed = new List<Edition>();
                for (int i = 0; i < 30; i++)
                {
                    int index = rand.Next(editions.Length);
                    if (i % 2 == 0)
                        Ed.Add(new Book(editions[index], authors[index], DateTime.Now, "asdfg"));
                    else if (i % 3 == 0)
                        Ed.Add(new Article(editions[index], authors[index], DateTime.Now, "asdfg", rand.Next(1, 100)));
                    else
                        Ed.Add(new ElectronicResource(editions[index], authors[index], "qwesf", "qweqwrqw"));
                }
                foreach (Edition item in Ed)
                {
                    item.print();
                }
                void searchByAuthor(string _author)
                {
                    foreach (Edition item in Ed)
                    {
                        if (item.author == _author)
                            item.print();
                    }
                }
                Console.WriteLine("\n--------------------------------------------------------------\n\n\n Поиск по автору\n");
                searchByAuthor("Maggie");
            }
            Zadanie1();
            void Zadanie3()
            {
                /*1.	Создать абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне, а также определить ее возраст (на момент текущей даты).
                  2.	Создать производные классы: Абитуриент (фамилия, дата рождения, факультет), Студент (фамилия, дата рождения, факультет, курс), Преподавать (фамилия, дата рождения, 
                  факультет, должность, стаж), со своими методами вывода информации на экран, и определения возраста.
                  3.	Создать базу (массив) из n персон, вывести полную информацию из базы на экран, а также организовать поиск персон, чей возраст попадает в заданный диапазон.*/

                List<Persona> Pers = new List<Persona>();
                for (int i = 0; i < 30; i++)
                {
                    int index = rand.Next(editions.Length);
                    if (i % 2 == 0)
                        Pers.Add(new Student(authors[index], DateTime.Now.AddYears(rand.Next(17, 40) * -1), (Faculty)rand.Next(0, 4)));
                    else if (i % 3 == 0)
                        Pers.Add(new Abiturient(authors[index], DateTime.Now.AddYears(rand.Next(17, 40) * -1), (Faculty)rand.Next(0, 4)));
                    else
                        Pers.Add(new Teacher(authors[index], DateTime.Now.AddYears(rand.Next(23, 40) * -1), (Faculty)rand.Next(0, 4), (Position)rand.Next(0, 4), rand.Next(1, 5)));
                }
                foreach (Persona item in Pers)
                {
                    item.print();
                    //Console.WriteLine("Возраст: {0}", item.returnAge());
                    Console.WriteLine();
                }
                void searchByAge(int from, int to)
                {
                    foreach (Persona item in Pers)
                    {
                        if (item.returnAge() >= from && item.returnAge() <= to)
                        {
                            item.print();
                            Console.WriteLine();
                        }

                    }
                }
                Console.WriteLine("\n---------------------------------------------------\nПоиск по диапазону возраста\n");
                searchByAge(18, 20);
            }
            //Zadanie3();
        }
    }
}
