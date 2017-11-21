using System;
using System.Threading;

namespace magic8ball
{
    class Program
    {
        public static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic 8 Ball!");
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            // clears console after key
            Console.Clear();

            while (true)
            {
                string question;
                //prompts user to ask question
                Console.Write("Ask a question. \n(Make sure it's 'yes or no', though): ");

                question = Console.ReadLine();

                if(question == "")
                {
                    // changes console color, yells at user
                    Console.ForegroundColor =  ConsoleColor.Red;
                    Console.Write("No, really. Ask a question! ");
                    DateTime _pause = DateTime.Now.AddSeconds(2);

                    while(_pause > DateTime.Now)
                    {
                        Thread.Sleep(1);
                    }

                    Console.Clear();

                    continue;
                }
                int RandomNum = rand.Next(5);

                //switch stmnt for RandomNum input
                switch(RandomNum)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Yes!");
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Nah");
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Maybe");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Nope");
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("I don't think so");
                        break;
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 'Q' to quit, or any other key if you've got more questions to ask! ");
            char input = Console.ReadKey().KeyChar;

            switch(input)
            {
                case 'q':
                    Console.ResetColor();
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    continue;
            }
        }
    }
}
}
