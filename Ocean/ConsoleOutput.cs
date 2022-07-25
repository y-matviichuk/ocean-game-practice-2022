using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean.Interface;

namespace Ocean
{
    public class ConsoleOutput : IView
    {
        public void InputIterations(Ocean ocean) // done 
        {
            Console.Write("\nType the number of operations (default = 20): ");
            ocean.iterations = (Convert.ToInt32(Console.ReadLine()));
        }

        public void InputRowsAndColumn(Ocean ocean) // done
        {
            Console.Write("Type the count of rows (default = 25): ");
            ocean.rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type the count of columns (default = 75): ");
            ocean.columns = (Convert.ToInt32(Console.ReadLine()));
        }

        public void InputValues(Ocean ocean) // done
        {
            Console.Write("Type the number of obstacles (default = 75): ");
            ocean.obstacles = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Type the number of predators (default = 20): ");
            ocean.predators = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Type the number of prey (default = 150): ");
            ocean.preys = (Convert.ToInt32(Console.ReadLine()));
        }

        public void Print(Ocean ocean)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("\nObstacles (#) - " + ocean.Obstacle + "   ");
            Console.WriteLine("Predators (S) - " + ocean.Predator + "   ");
            Console.WriteLine("Preys (f) - " + ocean.Prey + "   ");
            Console.WriteLine();
        }

        public void PrintIterations(Ocean ocean)
        {
            Console.WriteLine("Type number of operations: " + ocean.iterations);
            Console.Clear();
        }

        public void DisplayBorder(Ocean ocean)
        {
            for (int column = 0; column < ocean.columns; column++)
            {
                if (column == ocean.columns - 1)
                {
                    Console.WriteLine();
                }

                else if (column == 0)
                {
                    Console.Write("*");
                }

                else
                {
                    Console.Write("*");
                }
            }
            Thread.Sleep(150);
        }

        public void PrintException(string message) // done
        {
            Console.WriteLine(message);
        }

        public void DisplayCells(Ocean ocean)
        {
            for (int row = 0; row < ocean.rows; row++)
            {
                for (int column = 0; column < ocean.columns; column++)
                {
                    Console.Write(ocean.cells[row, column].image);
                }
                Console.Write("\n");
            }
        }

    }
}
