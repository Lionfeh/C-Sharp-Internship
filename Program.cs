using square;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //С правильным вводом
            Console.WriteLine("С правильным вводом");
                //Для круга
            Console.WriteLine(Square.Circle(5));
            Console.WriteLine(Square.Circle(10));
                //Для треугольника
            Console.WriteLine(Square.Triangle(3, 4, 5));
            Console.WriteLine(Square.IsRightTriangle(3, 4, 5));
                //Для неизвестной фигуры
            Console.WriteLine(Square.UnknownSquare(5));
            Console.WriteLine(Square.UnknownSquare(3, 4, 5));

            //С не правильным вводом
            Console.WriteLine("С не правильным вводом");
                //Для круга
            Console.WriteLine(Square.Circle(-4));
            Console.WriteLine(Square.Circle(0));
                //Для треугольника
            Console.WriteLine(Square.Triangle(1, 1, 19));
            Console.WriteLine(Square.IsRightTriangle(-1, -2 , -3));
                //Для неизвестной фигуры
            Console.WriteLine(Square.UnknownSquare(-2));
            Console.WriteLine(Square.UnknownSquare(0, 3, 4));

            Console.ReadKey();
        }
    }
}


/*
 * 3ье задание
 SELECT name, category 
 FROM sqlServer
 
 SELECT name 
 FROM sqlServer
 WHERE name == NULL
*/
