using System;
using System.Drawing;

namespace ALBRIGHT_ASSIGNMENT_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* MSSA CCAD 16
             * CHRIS ALBRIGHT
             * DAY 04 - 7NOV2024
             */

            // ASSIGNMENT 1-4
            Console.WriteLine("\nASSIGNMENT 1-4");
            string continueString;

            do
            {

                Point P1 = new Point();
                Console.WriteLine("\n\nEnter P1 X Coord.:");
                P1.x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter P1 Y Coord.:");
                P1.y = Convert.ToDouble(Console.ReadLine());

                Point P2 = new Point();
                Console.WriteLine("\nEnter P2 X Coord.:");
                P2.x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nEnter P2 Y Coord.:");
                P2.y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nP1 == ( " + P1.x + " , " + P1.y + " ) ");
                Console.WriteLine("\nP2 == ( " + P2.x + " , " + P2.y + " ) ");

                if (P1.x > P2.x)
                {
                    Console.WriteLine("\nP1 is right of P2");
                }
                else if (P1.x == P2.x)
                {
                    Console.WriteLine("\nP1 is x aligned with P2");
                }
                else
                {
                    Console.WriteLine("\nP1 is left of P2");
                }

                Console.WriteLine("\nType c to continue area calculations or any other character to exit");
                continueString = Console.ReadLine();
            }
        
            while (continueString == "c");

            Console.WriteLine("\nGoodbye!");
        }
    }
    public class Point
    {
        public Point(double xCoord, double yCoord)
        {
            x = xCoord;
            y = yCoord;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public double x; 
        public double y;

    }
}
