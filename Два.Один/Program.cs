using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Два.Один
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите y:");
                double y = double.Parse(Console.ReadLine());
                bool r = x >= Math.Abs(y) && y >= -1 && y <= 1 && x >= 0 && x <= 1;
                Console.WriteLine(r);
            
        }
    }
}
