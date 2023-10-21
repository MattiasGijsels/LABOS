namespace Labo_18_10_oplossing_oef_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {

                Console.Write(">");
                string input = Console.ReadLine() ?? "";
                switch (input.ToLower())
                {
                    case "exit":
                    case "quit":
                        isRunning = false;
                        break;
                    case "echo":
                        Console.WriteLine($"You Wrote '{input}");
                        break;
                    case "clear":
                        Console.Clear();
                        break;

                    default:
                       
                        ShowError($"The following command is wrong {input}");
                        // f11 step into
                        break;
                         etz

                }





            }
        }
       
        static void ShowError(string error) 
        {
            Console.WriteLine($"You Wrote the following error" + Console.ReadLine());
            


        }
        
    }
}