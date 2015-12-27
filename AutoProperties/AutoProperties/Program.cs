using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Program
    {
        static void doWork()
        {
            //
            Polygon square = new Polygon();
            Polygon triangle=new Polygon {NumSides=3};
            Polygon pentagon = new Polygon { Sidelength = 15.5, NumSides = 5 };

            Console.WriteLine("suqare:number of sides is {0},length of each side is {1}", square.NumSides, square.Sidelength);
            Console.WriteLine("triangle:number of sides is {0},length of each side is {1}", triangle.NumSides, triangle.Sidelength);
            Console.WriteLine("pentagon:number of sides is {0},length of each side is{ 1}", pentagon.NumSides, pentagon.Sidelength);

        }
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
