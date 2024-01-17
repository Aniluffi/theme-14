using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        int y;
        int x;
        static int count;
        int count2 = Point.count + 1;//добавил новое приватное поле чтобы при показом длины между двумя точками мы могли увидеть номера точек у которых мы ищем длину между друг другом 
        

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
   

        public Point ()
        {
            PointNumber();
            Print();
        }

        public Point(int x,int y)
        {
            PointNumber();

            this.X = x;
            this.Y = y;

            Print();
        }

        static Point()
        {
           
        }

        private void PointNumber()
        {
           
            Point.count += 1;
         
        }

        private void Print()
        {
            Console.WriteLine($"Экземпляр №{count}\n" +
                $"Координаты Y = {Y}\n" +
                $"Координаты X = {X}\n");

        }

        public static void LengthPoints(Point a,Point b)
        {
            Console.WriteLine($"длина между точкой №Х{a.count2} И №Х{b.count2} = {Math.Round(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y + b.Y, 2)),2)}");
        }
    }
}
