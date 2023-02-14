using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

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

            string quitString = "";
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
                foreach (Word word in scripture.getScriptureText())
                {
                    Console.Write(word.showWord() + " ");
                }
                Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
                quitString = Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    randomNumber = random.Next(0, scripture.getScriptureText().Count);
                    scripture.getScriptureText()[randomNumber].setHidden(true);
                    Console.WriteLine(randomNumber);
                }
            }
        }
        class Reference
        {
            private string chapterNumber;

            public Reference(string bookNameParam, string chapterNumberParam, string verseNumberParam)
            {
                BookName = bookNameParam;
                ChapterNumber = chapterNumberParam;
                VerseNumber = verseNumberParam;
                EndVerseNumber = "X";
            }

            public Reference(string bookNameParam, string chapterNumberParam, string verseNumberParam, string endVerseNumberParam)
            {
                BookName = bookNameParam;
                ChapterNumber = chapterNumberParam;
                VerseNumber = verseNumberParam;
                EndVerseNumber = endVerseNumberParam;
            }

            public string BookName { get; set; }
            public string ChapterNumber { get => chapterNumber; set => chapterNumber = value; }
            public string VerseNumber { get; set; }
            public string EndVerseNumber { get; set; }
            public string PrintFullReference1 { get; set; } = " ";

            public void PrintFullReference()
            {
                if (EndVerseNumber == "X")
                {
                    Console.Write(BookName + " " + ChapterNumber + ":" + VerseNumber + " ");
                }
                else
                {
                    Console.Write(BookName + " " + ChapterNumber + ":" + VerseNumber + "-" + EndVerseNumber + " ");
                }

            }



        }

        class Scripture
        {
            private Reference reference;
            private List<Word> scriptureText;
            public Scripture(Reference referenceParam, List<Word> textParam)
            {
                Reference = referenceParam;
                ScriptureText = textParam;
            }

            private Reference Reference { get => reference; set => reference = value; }
            private List<Word> ScriptureText { get => scriptureText; set => scriptureText = value; }

            public Reference getReference()
            {
                return Reference;

            }
            public List<Word> getScriptureText()
            {
                return ScriptureText;
            }
        }

        class Word
        {
            public Word(string wordParam)
            {
                HiddenWord = "";
                WordVal = wordParam;
                foreach (char x in WordVal)
                {
                    HiddenWord = HiddenWord + "_";
                }
            }
            public Word(string wordParam, bool isHiddenParam)
            {
                HiddenWord = "";
                WordVal = wordParam;
                IsHidden = isHiddenParam;

                foreach (char x in WordVal)
                {
                    HiddenWord = HiddenWord + "_";
                }
            }

            private string hiddenWord;
            private string wordVal;
            private bool isHidden;

            public string HiddenWord { get => hiddenWord; set => hiddenWord = value; }
            public string WordVal { get => wordVal; set => wordVal = value; }
            public bool IsHidden { get => isHidden; set => isHidden = value; }

            public string showWord()
            {
                if (IsHidden == true)
                {
                    return HiddenWord;
                }
                else
                {
                    return WordVal;
                }
            }
            public void setHidden(bool isHiddenParam)
            {
                IsHidden = isHiddenParam;
            }





        }
    }
}