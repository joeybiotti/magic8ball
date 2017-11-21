using System;

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
                    continue;
                }
                int RandomNum = rand.Next(5);

                //switch stmnt for RandomNum input
                switch(RandomNum)
                {
                    case 0:
                        Console.WriteLine("Yes!");
                        break;

                    case 1:
                        Console.WriteLine("Nah");
                        break;

                    case 2:
                        Console.WriteLine("Maybe");
                        break;

                    case 3:
                        Console.WriteLine("Nope");
                        break;

                    case 4:
                        Console.WriteLine("I don't think so");
                        break;
            }

            Console.WriteLine("Press 'Q' to quit, or any other key if you've got more questions to ask! ");
            char input = Console.ReadKey().KeyChar;

            switch(input)
            {
                case 'q':
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
