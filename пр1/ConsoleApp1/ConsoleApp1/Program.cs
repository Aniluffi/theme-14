using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        public static void Main(string[] args)
        {  
            Point len = new Point(1,2);
            Point len2 = new Point();
            Point len3 = new Point();
            Point len4 = new Point(5,6);
            Point len5 = new Point(10,2);
            Point len6 = new Point();

            Point.LengthPoints(len4,len5);
            //len1.Print();
            //len2.Print();
            //len3.Print();
            //len4.Print();
            //len5.Print();
            //len.Print();
          
        }
    }
}
