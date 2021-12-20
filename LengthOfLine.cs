using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractoredLineProblems
{
    class LengthOfLine
    {



        //declaring fields
        //x1,y1,x2,y2
        int x1, y1, x2, y2;
        int point1 = 0;
        int point2 = 0;
        double total;
        float Length1 = 0;
        float Length2 = 0;




        public LengthOfLine(int X1, int Y1, int X2, int Y2)
        {
            this.x1 = X1;
            this.y1 = Y1;

            this.x2 = X2;
            this.y2 = Y2;
        }

        public double CalculateLengthOfLine()
        {
            int point1 = x2 - x1;
            int point2 = y2 - y1;
            Console.WriteLine("cordinates are x1,y1,x2,y2 {0} {1} {2} {3}", x1, y1, x2, y2);
            double total = Math.Pow(point1, 2) + Math.Pow(point2, 2);
            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            //Console.WriteLine(total);
            return total;
        }

    }
}
