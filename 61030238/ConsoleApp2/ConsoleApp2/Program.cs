using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Teacher teacher = new Teacher("Tom", 350f);
            Professor prof = new Professor("Jerry", 500f, 5000f);
            // teacher work 20Hr/month
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                teacher.CalculateCharge(20f));
            // professor work 12Hr/month
            Console.WriteLine("{0} charge = {1}", prof.TypeName(),
                prof.CalculateCharge(12F));
            Console.ReadLine();
        }
    }
    
}

