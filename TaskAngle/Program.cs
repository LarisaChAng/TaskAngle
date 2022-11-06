using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAngle
{
    class Program
    {
        
        static void Main(string[] args)
            
        {
            Console.WriteLine("Значение угла из градусов в радианы");
            Console.WriteLine("Введите последовательно градусы-минуты-секунды УГЛА (в целых числах):");
            int g = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            AngleToRAD anGrR = new AngleToRAD (g, m, s);
            
            double totalRad = anGrR.ToRad();            
            int totalGRad = anGrR.ToGRad();

            Console.WriteLine("Значение угла в радианах {0:0.000}, а в градусах {1}", totalRad, totalGRad);
            Console.ReadKey();
        }        
    }
}
