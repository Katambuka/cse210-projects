using System;
using System.Collections.Generic;

namespace Namespace
{
    // Static class that contains the program's entry point
    static class HelloWorld
    {
        static void Main()
        {
            // Declare and initialize variables
            Scripture scripture;
            Reference reference = new Reference("Proverbs", "3", "5", "6"); // Create new reference object with book, chapter, verse, and end verse

            Random random = new();
            int randomNumber;

            string quitString = "";
            const string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."; // Scripture text to be split into words
            string[] splitScriptureText = scriptureText.Split(" "); // Split scripture text into individual words

            List<Word> wordList = new(); // Create new list to hold Word objects

            // Loop through each word in the scripture text
            foreach (string x in splitScriptureText)
            {
                // Create a new Word object for the current word and add it to the list
                wordList.Add(new Word(x));
            }

            // Create new scripture object using the reference and word list
            scripture = new Scripture(reference, wordList);

            // Loop until the user enters "quit"
            while (quitString != "quit")
            {
                // Print the full reference for the scripture
                reference.PrintFullReference();

                // Loop through each word in the scripture and display it, either hidden or not
                foreach (Word word in scripture.GetScriptureText())
                {
                    Console.Write(word.showWord() + " ");
                }

                Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
                quitString = Console.ReadLine();

                // Loop three times and randomly hide a word each time
                for (int i = 0; i < 3; i++)
                {
                    randomNumber = random.Next(0, scripture.GetScriptureText().Count);
                    scripture.GetScriptureText()[randomNumber].setHidden(true);
                    Console.WriteLine(randomNumber);
                }
            }
        }
    }
}
