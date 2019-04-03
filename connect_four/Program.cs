using System;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validating arguments
            if (args.Length != 2)
            {
                throw new ArgumentException("Invalid number of arguments");
            }

            else if (!args[1].Equals("--state"))
            {
                throw new ArgumentException("Argument must be '--state'");
            }

            Board board = new Board(args[1]);

        }
    }
}
