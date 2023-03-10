using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : Namespace.MindfulnessActivity
    {
        // array of prompts to display to the user
        private readonly string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // static instance of the Random class to generate random prompts
        private static readonly Random random = new();

        public override void StartActivity(int duration)
        {
            // display the activity description and prompt for duration
            Console.WriteLine("Listing Activity: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.Write("Please enter the duration of the activity in seconds: ");
            int activityDuration = int.Parse(Console.ReadLine());

            // generate a random prompt and display it to the user along with the activity duration
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine("Prompt: " + prompt);
            Console.WriteLine("You have " + activityDuration + " seconds to list as many items as you can.");

            // countdown for 5 seconds before allowing the user to begin
            Thread.Sleep(5000);

            // track the start time and number of items listed by the user
            DateTime startTime = DateTime.Now;
            int itemsCount = 0;

            // loop until the duration has passed or the user enters a blank input
            while ((DateTime.Now - startTime).TotalSeconds < activityDuration)
            {
                Console.Write("Enter an item: ");
                string input = Console.ReadLine();

                // if the user enters a blank input, break out of the loop
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                // increment the item count for each non-blank input
                itemsCount++;
            }

            // display the number of items listed by the user
            Console.WriteLine("You listed " + itemsCount + " items.");

            // display the standard finishing message for all activities
            Console.WriteLine("Listing activity completed.");
        }
    }
}
