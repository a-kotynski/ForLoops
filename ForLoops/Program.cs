using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2169340#content
namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0) //remainder of a division i by 2
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}