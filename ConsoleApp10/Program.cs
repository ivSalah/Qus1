using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salah.H.W
{
    class student
    {
        public int id;
        public string name;
        public int mark;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num of students: ");
            Console.WriteLine("must be 5-10 :");
            int c = int.Parse(Console.ReadLine());
            if (c >= 5 && c <= 10)
            {
                List<student> list = new List<student>();
                for (int i = 0; i < c; i++)
                {
                    student s = new student();
                    Console.WriteLine("enter name of student: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter ID of student: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter mark of student :");
                    int mark = int.Parse(Console.ReadLine());
                    s.mark = mark;
                    s.name = name;
                    s.id = id;
                    list.Add(s);

                }
                bool found = false;
                Console.WriteLine("student how pass is : ");
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].mark >= 50)
                    {
                        found = true;
                        Console.WriteLine("the name student :" + list[i].name);
                        Console.WriteLine("the id of student :" + list[i].id);
                    }
                }
                if (!found)
                    Console.WriteLine("no one  pass ");
                

            }
            else 
                Console.WriteLine("the student must be 5-10. ");
                Console.ReadLine();
            
        }
    }
}
