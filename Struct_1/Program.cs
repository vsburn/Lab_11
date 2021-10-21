using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_1
{
    class Program
    {
        #region Задача
        /* 
         * Разработать структуру для решения линейного уравнения 0=kx+b.
         * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
         * Для решения уравнения предусмотреть метод Root. 
         * Создать экземпляр разработанной структуры.
         * Осуществить использование экземпляра в программе.
         */
        #endregion
        static void Main(string[] args)
        {
            Console.Write("k = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            LinEq linEq = new LinEq { K = k, B = b };
            double x;
            if ((linEq.K == 0) && (linEq.B == 0))
            {
                Console.WriteLine("Корней бесконечно много");
            }
            else if ((linEq.K != 0) && (linEq.B == 0))
            {
                x = 0;
                Console.WriteLine("x = " + x);
            }
            else if ((linEq.K == 0) && (linEq.B != 0))
                Console.WriteLine("Уравнение не имеет корней");
            else
            {
                x = linEq.Root();
                Console.WriteLine("x = " + x);
            }
            Console.ReadKey();
        }

        struct LinEq
        {
            public double B { get; set; }
            public double K { get; set; }

            public double Root()
            {
                return -B / K;
            }

        }
    }
}
