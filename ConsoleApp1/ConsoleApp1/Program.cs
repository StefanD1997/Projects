using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot(0, 5);
            r1.moveX(1);
            r1.printCurrentCoordinates();
            r1.moveY(2);
            r1.printCurrentCoordinates();
            r1.printLastCoordinates();
            r1.printLastMove();
        }

        public class Robot
        {
            int currentX;
            int currentY;
            int previousX;
            int previousY;
            List<string> usedMethods = new List<string>();
            int movedX;
            int movedY;

            public Robot(int X, int Y)
            {
                X = 0;
                Y = 5;
                currentX = X;
                currentY = Y;
            }


            public void moveX(int dx)
            {
                previousX = currentX;
                currentX = currentX + dx;
                movedX = dx;
                usedMethods.Add("moveX");
            }

            public void moveY(int dy)
            {
                previousY = currentY;
                currentY = currentY + dy;
                movedY = dy;
                usedMethods.Add("moveY");
            }

            public void moveBackX(int ds)
            {
                previousX = currentX;
                currentX = currentX - ds;
                movedX = ds;
                usedMethods.Add("moveBackX");
            }

            public void moveBackY(int df)
            {
                previousY = currentY;
                currentY = currentY - df;
                movedY = df;
                usedMethods.Add("moveBackY");
            }

            public void printCurrentCoordinates()
            {
                Console.Write("X: {0}, Y: {1}\n", currentX, currentY);
            }

            public void printLastCoordinates()
            {
                Console.Write("X: {0}, Y: {1}\n", previousX, previousY);
            }

            public void printLastMove()
            {
                var lastItem = usedMethods[usedMethods.Count - 1];
                if ( lastItem == "moveX")
                {
                    Console.Write("x " + movedX + "\n");
                }
                else if (lastItem == "moveY")
                {
                    Console.Write("y " + movedY +"\n");
                }
                else if (lastItem == "moveBackX")
                {
                    Console.Write("x " + movedX + "\n");
                }
                else if (lastItem == "moveBackY")
                {
                    Console.Write("y " + movedY + "\n");
                }
                else
                {
                    Console.Write("Robot has not moved\n");
                }
            }
        }
    }
}
