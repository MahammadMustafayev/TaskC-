using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 0;
            do
            {
                Console.WriteLine("---------Menu---------");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangular");
                Console.WriteLine("0.Quit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Enter the number:");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        
                        double side = 0;
                        while (side <=0)
                        {
                            Console.WriteLine("Enter the side of the square:");
                            side = Convert.ToDouble(Console.ReadLine());
                            if (side<=0)
                            {
                                Console.WriteLine("The number is negative");
                            }
                        }
                        Square S = new Square(side);
                        Console.WriteLine($"The area of the square:{S.CalcArea()}");
                        Console.WriteLine("----------------------------");
                        break;
                    case 2:
                        double width = 0;
                        double length = 0;
                        while (width<=0)
                        {
                            Console.WriteLine("Enter the width of the Rectangle:");
                            width = Convert.ToDouble(Console.ReadLine());
                            if (width<=0)
                            {
                                Console.WriteLine("The number is negative");
                            }
                        }
                       

                        while (length<=0)
                        {
                            Console.WriteLine("Enter the length of the Rectangle:");
                            length = Convert.ToDouble(Console.ReadLine());
                            if (length<=0)
                            {
                                Console.WriteLine("The number is negative");
                            }
                        }
                        Rectangular A = new Rectangular(width, length);
                        Console.WriteLine($"The area of a rectangle:{A.CalcArea()}");
                        Console.WriteLine("----------------------------");
                        break;
                    case 0:
                        Console.WriteLine("Thank You.Good bye");
                        Console.WriteLine("----------------------------");
                        break;
                    default:
                        Console.WriteLine("You entered incorrectly");
                        break;
                }
            } while (key != 0);
        }
    }
    abstract class Figure
    {
        public abstract double CalcArea();
    }
    class Square:Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double CalcArea()
        {
            return Side * Side;
        }
    }
    class Rectangular:Figure
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangular(double width,double length)
        {
            Width = width;
            Length = length;
        }
        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
