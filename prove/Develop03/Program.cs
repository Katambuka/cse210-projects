using System;
using System.Collections.Generic;

namespace Namespace
{
    static class HelloWorld
    {
        static void Main()
        {
            Scripture scripture;
            Reference reference = new Reference("Proverbs", "3", "5", "6");

            Random random = new();
            int randomNumber;

            string quitString = " ";
            const string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            string[] splitScriptureText = scriptureText.Split(" ");

            List<Word> wordList = new();

            foreach (string x in splitScriptureText)
            {
                wordList.Add(new Word(x));
            }

            scripture = new Scripture(reference, wordList);

            while (quitString != "quit")
            {
                reference.PrintFullReference();
                foreach (Word word in scripture.GetScriptureText())
                {
                    Console.Write(word.ShowWord() + " ");
                }
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                quitString = Console.ReadLine();
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