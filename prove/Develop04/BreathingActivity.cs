using System;
using System.Threading;

namespace Namespace2
{
    public class BreathingActivity : Namespace.MindfulnessActivity
    {
        // override the base class method with our own implementation
        public override void StartActivity(int duration)
        {
            // print some introductory messages
            Console.WriteLine("Breathing Activity: This activity will guide you through a breathing exercise to help you relax and focus.");
            Console.WriteLine("Take a comfortable seat and close your eyes.");

            // wait for 3 seconds
            Pause(3);

            // instruct the user to take a deep breath in
            Console.WriteLine("Take a deep breath in through your nose, filling your lungs completely.");

            // animate a message instructing the user to hold their breath for 3 seconds
            Animate("Hold your breath for 3 seconds.", 3);

            // instruct the user to exhale slowly
            Console.WriteLine("Slowly exhale through your mouth, emptying your lungs completely.");

            // animate a message instructing the user to pause for 1 second
            Animate("Pause for 1 second.", 1);

            // instruct the user to repeat the cycle for the given duration
            Console.WriteLine("Repeat this cycle for " + duration + " seconds.");

            // calculate the number of cycles needed to reach the given duration
            int cycles = duration / 7; // each cycle takes 7 seconds

            // loop through the required number of cycles
            for (int i = 0; i < cycles; i++)
            {
                // instruct the user to inhale
                Console.WriteLine("Inhale...");

                // animate a message instructing the user to hold their breath for 3 seconds
                Animate("Hold for 3 seconds...", 3);

                // instruct the user to exhale
                Console.WriteLine("Exhale...");

                // animate a message instructing the user to pause for 1 second
                Animate("Pause for 1 second...", 1);
            }

            // print a message indicating that the activity is complete
            Console.WriteLine("You've completed the breathing exercise. Take a moment to notice how you feel.");
        }
    }
}
