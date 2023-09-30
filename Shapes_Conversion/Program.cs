using System;

namespace Shapes_Conversion
{
    class Program
    {

        static void Main(string[] args)
        { 

            while (true)
            {
                //Enter input
                Console.WriteLine("What shape would you like to print? ");
                string input = Console.ReadLine().ToLower();
                
                //based on input, find the shape
                switch (input)
                {
                    case "triangle":
                        buildTriangle();
                        break;

                    case "diamond":
                        buildDiamond();
                        break;

                    case "square":
                        buildSquare();
                        break;

                    default:
                        Console.WriteLine("Invalid Input!, I don't understand. Please enter (square, triangle, or diamond)!");
                        break;

                }
                
                //eveluate if you want to finish the game or not
                if (!isFinished())
                {
                    break;
                }
            }
        }


        //triangle function
        static void buildTriangle()
        {
            while (true)
            {
                Console.WriteLine("Please enter the height of the triangle ");
                if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
                {

                    for (int i = 1; i <= height; i++)
                    {

                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("x" + " ");
                        }


                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand. Please enter integer!");
                }
            }
        }

        // Square Function
        static void buildSquare()
        {
            while (true)
            {
                Console.WriteLine("Please enter the height of Square: ");
                if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            Console.Write("x" + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand. Please enter an integer!");
                }
            }
        }

        //Diamond function
        static void buildDiamond()
        {
            while (true)
            {
                Console.WriteLine("Please enter the height of the Diamond");
                if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
                {
                    for (int i = 1; i < height; i++)
                    {
                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("x" + " ");
                        }

                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        Console.WriteLine();
                    }

                    for (int i = height; i >= 1; i--)
                    {
                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("x" + " ");
                        }
                        Console.WriteLine(" ");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand. Please enter an integer!");
                }
            }
        }

        // check if use want to play again?
        static bool isFinished()
        {
            Console.WriteLine("Would you like to do this Again? Yes(y)/No(n)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer =="y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
