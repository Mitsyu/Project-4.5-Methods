namespace Project_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("1. Kettle and Mug");
                Console.WriteLine("2. Wine Bottle");
                Console.WriteLine("3. Pizza");
                Console.WriteLine("4. Tell Knock Knock Joke");
                Console.WriteLine(); 

                Console.WriteLine("Choose what program to run (1-3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DrawCups();
                        break;

                    case "2":
                        DrawWine();
                        break;

                    case "3":
                        DrawPizza();
                        break;

                    case "4":
                        TellJoke();
                        break;

                    default:
                        Console.WriteLine("Invaild");
                            break;


                }

            } 

        }

        public static void DrawCups()
        {
            Console.WriteLine("             ;,'          )  (");
            Console.WriteLine("     _o_    ;:;'         (   ) )");
            Console.WriteLine(" ,-.'---`.__ ;            ) ( (");
            Console.WriteLine("((j`=====',-'             ) ( (");
            Console.WriteLine(" `-\\     /           .-'---------|  ");
            Console.WriteLine("    `-=-'           ( C|/\\/\\/\\/\\/|");
            Console.WriteLine("                     '-./\\/\\/\\/\\/|");
            Console.WriteLine("                       '_________'    ");
            Console.WriteLine("                        '-------'    ");
        }

        public static void DrawWine()
        {
            Console.WriteLine("  _");
            Console.WriteLine(" {_}");
            Console.WriteLine(" |(|");
            Console.WriteLine(" |=|");
            Console.WriteLine("/   \\");
            Console.WriteLine("|.--|");
            Console.WriteLine("||  |");
            Console.WriteLine("||  |");
            Console.WriteLine("|'--| ");
            Console.WriteLine("'-=-'");
        }

        public static void DrawPizza()
        {
            Console.WriteLine("// \"\"--.._");
            Console.WriteLine("||  (_)  _ \"-._");
            Console.WriteLine("||    _ (_)    '-.");
            Console.WriteLine("||   (_)   __..-'");
            Console.WriteLine(" \\\\__..--\"\"");
            Console.WriteLine("");
        }

        public static void TellJoke()
        {
            Console.WriteLine("Knock knock");
            Console.ReadLine();

            Console.WriteLine("Who's there?");
            Console.ReadLine();
            
            Console.WriteLine("Tank.");
            Console.ReadLine();

            Console.WriteLine("Tank who?");
            Console.ReadLine();

            Console.WriteLine("Your welcome.");
            Console.ReadLine();


        }
    }
}