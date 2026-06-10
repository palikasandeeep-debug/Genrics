using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics
{
    internal class Program
    {

        class genric
        {
            internal void display<p>(p a)
            {
                Console.WriteLine("a values is"+a);
            }
            internal void cal<p>(p b,p c)
            {
                Console.WriteLine("b values is" + b);
                Console.WriteLine("c vlue is"+c);
            }
            internal void dtypes<p,k>(p b, k c)
            {
                Console.WriteLine("b values is" + b);
                Console.WriteLine("c vlue is" + c);
            }

        }
        static void Main(string[] args)
        {
            genric g = new genric();
            g.display<int>(100);
            g.display<string>("sandy");
            g.cal<string>("palika","sandy");
            g.cal<double>(0.3, 0.5);
            g.dtypes<int, string>(100, "chary");
            g.dtypes<string, int>("sandy", 123);
        }
    }
}
