using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("aaaa22");
            Console.WriteLine("bbbb222");
            Student aStudent = new Student();
            aStudent.name = "aaabbb";
            aStudent.phone = "123456789";
            Console.WriteLine("{0}{1}", aStudent.name, aStudent.phone
                );
        }
    }
}