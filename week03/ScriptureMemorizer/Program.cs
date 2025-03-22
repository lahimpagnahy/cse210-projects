using System;

class Program
{
    static void Main(string[] args)
    {
        // Remarque 1 
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        // Remarque 2
        Scripture scripture = new Scripture(reference, 
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        // Remarque 3
        bool quit = false;
        
        while (!scripture.IsCompletelyHidden() && !quit)
        {
            // Remarque 4
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            
            // Remarque 5
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            
            // Remarque 6
            if (input.ToLower() == "quit")
            {
                quit = true;
            }
            else
            {
                // Remarque 7
                scripture.HideRandomWords(3);
            }
        }
        
        // Remarque 9
        if (!quit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words have been hidden. Great job memorizing!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
