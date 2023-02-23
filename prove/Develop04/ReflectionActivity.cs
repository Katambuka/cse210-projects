using System.Diagnostics; // provides access to the Stopwatch class for measuring elapsed time
using System.Threading; // provides access to the Thread class for adding delays

namespace Namespace3
{
    public class ReflectionActivity : Namespace.MindfulnessActivity
    {
        // an array of prompts to randomly select from
        private static readonly string[] Prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // a static Random object for generating random numbers
        private static readonly Random Random = new();

        // override the StartActivity method to implement the reflection activity
        public override void StartActivity(int duration)
        {
            // print an introduction message to the console
            Console.WriteLine("Reflection Activity: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            // animate a spinner to simulate the generation of a prompt
            AnimateSpinner("Generating prompt", 5);

            // randomly select a prompt from the Prompts array
            string prompt = Prompts[Random.Next(Prompts.Length)];

            // print the selected prompt to the console
            Console.WriteLine("Prompt: " + prompt);

            // print the reflection duration to the console
            Console.WriteLine($"You have {duration} seconds to reflect on your prompt...");

            // create a Stopwatch object to measure elapsed time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // loop until the reflection duration has elapsed
            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                Thread.Sleep(1000); // pause for 1 second
            }

            // print a message indicating that the reflection activity is complete
            Console.WriteLine("Time's up!");
        }

        // a helper method to animate a spinner in the console
        private static void AnimateSpinner(string message, int durationInSeconds)
        {
            Console.Write(message);
            for (int i = 0; i < durationInSeconds; i++)
            {
                Console.Write("."); // print a dot
                Thread.Sleep(500); // pause for half a second
            }
            Console.WriteLine(); // move to the next line in the console
        }
    }
}
