using System;
using Lib;

namespace MindBoxTestTask
{
    internal class Program
    {
        private static CalcFiguresArea cfa = new CalcFiguresArea();
        
        static void IsRectangularChoice(int a, int b, int c)
        {
            Console.Write("Do you want to check the triangle for squareness? (yes/y OR no/n)\n" +
                          "> ");

            string choiceRectangular = Console.ReadLine();
            
            switch (choiceRectangular)
            {
                case "":
                case "yes":
                case "y":
                {
                    Console.WriteLine(cfa.IsTriangleRectangular(a, b, c)
                        ? "Triangle is rectangular"
                        : "Triangle is not rectangular");
                    break;
                }
                case "no":
                case "n":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Choose yes/y or no/n");
                    break;
                }
            }
        }
        
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("The area of which shape you want to calculate?\n" +
                                  "1). The area of the circle by radius\n" +
                                  "2). The area of the triangle by three sides\n" +
                                  "Enter the number of the menu item and press ENTER.\n" +
                                  "Enter 0 to exit the program.");
                Console.Write("> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                if (choice==0) break; // exiting the program
                
                switch (choice)
                {
                    case 1:
                    {
                        Console.Write("Enter radius: ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        // calculating the area of a circle by radius
                        Console.WriteLine(cfa.CircleAreaCalc(r));
                        
                        Console.WriteLine("To exit the menu, press any key");
                        Console.ReadLine();
                        break;
                    }
                    case 2:
                    {
                        Console.Write("Enter a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter b: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter c: ");
                        int c = Convert.ToInt32(Console.ReadLine());

                        // optionally checking the triangle for rectangularity
                        IsRectangularChoice(a, b, c);
                        
                        // calculating the area of a triangle on three sides
                        Console.WriteLine(cfa.TriangleAreaCalc(a, b, c));
                        
                        Console.WriteLine("To exit the menu, press any key");
                        Console.ReadLine();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Enter the correct value");
                        
                        Console.WriteLine("To exit the menu, press any key");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}