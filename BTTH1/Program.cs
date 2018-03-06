using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, y;
            Console.WriteLine("Nhap Vao Thang: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Vao Nam: ");
            y = int.Parse(Console.ReadLine());
            switch(m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", m);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", m);
                    break;
                case 2:
                    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                        Console.WriteLine("Thang {0} co 29 ngay", m);
                    else
                        Console.WriteLine("Thang {0} co 28 ngay ", m);
                            break;
            }
            Console.ReadLine();
        }
    }
}
