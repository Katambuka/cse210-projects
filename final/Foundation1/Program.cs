using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // a list of videos
        List<Video> videos = new List<Video>();

        // 3 videos and added comments to them
        Video v1 = new Video("Video 1", "John Doe", 120);
        v1.AddComment("Alice", "Great video!");
        v1.AddComment("Bob", "I agree, very informative.");

        Video v2 = new Video("Video 2", "Jane Smith", 180);
        v2.AddComment("Charlie", "Thanks for sharing!");

        Video v3 = new Video("Video 3", "Mike Johnson", 90);
        v3.AddComment("David", "I learned a lot from this video.");

        // Add the videos to the list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display information for each video in the list
        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length: " + v.Length + " seconds");
            Console.WriteLine("Number of comments: " + v.GetNumberOfComments());

            // Display all the comments for the video
            foreach (Comment c in v.Comments)
            {
                Console.WriteLine("- " + c.CommenterName + ": " + c.Text);
            }

            Console.WriteLine(); // Add a blank line for spacing
        }
    }
}
