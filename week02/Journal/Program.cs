using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while(choice !="5")
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Choose an option: ");

            choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("Your response: ");

                string response = Console.ReadLine();

                Entry entry = new Entry();
                
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);

                Console.WriteLine("Journal entry added!");
                Console.WriteLine();
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded succesfully!");
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved succesfully!");
            }

            else if (choice == "5")
            {
                Console.WriteLine("Have a great day!");
            }
            
        }

    }
}