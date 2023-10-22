namespace Labo_18_10_oplossing_oef_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            string[] cursorChoice = { "$ " , "* ", "ù ", "£ " };

            while (isRunning)
            {
                string customCursor = "> ";
                Console.Write(customCursor);
                string userInput = Console.ReadLine() ?? "";
                switch (userInput.ToLower())
                {
                    case "exit":
                    case "quit":
                        isRunning = false;
                        break;

                    case "echo":
                        Console.WriteLine($"You Wrote '{userInput}'");
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    case "change the cursor":
                        Console.WriteLine($"To change your cursor, type one of the following symbols ");
                    foreach (string choice in cursorChoice)
                    {
                        Console.WriteLine(choice);
                    }
                        Console.ReadLine();
                        Console.WriteLine(ChangeCursor(userInput));
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ShowError(userInput));
                        Console.ResetColor(); 
                        break;
                      
                }

            }
        }
       
        static string ShowError(string error) 
        {   
            return ($"You Wrote the following error '{error}'");
        }
        static string ChangeCursor (string newCursor) 
        {
            newCursor = Console.ReadLine();
            return newCursor;

        }
    }
}