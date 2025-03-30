using System;
using System.Collections.Generic;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            Video video1 = new Video("How to Study", "Mario Leon", 500);
            video1.Comments.Add(new Comment("Jean", "It was very helpful. Now I am studying better."));
            video1.Comments.Add(new Comment("Josue", "Good video bro"));
            video1.Comments.Add(new Comment("Derek", "I like your chanel"));

            Video video2 = new Video("Is Biotech the next revolution?", "Orochimaru", 200);
            video2.Comments.Add(new Comment("Naruto", "I better start learning that"));
            video2.Comments.Add(new Comment("Sasuke", "Fr that's crazy"));
            video2.Comments.Add(new Comment("Sakura", "facts"));

            Video video3 = new Video("How to land a job in software engineering", "Elias Euvin", 700);
            video3.Comments.Add(new Comment("David", "I followed your advice and I'm still broke :("));
            video3.Comments.Add(new Comment("Pepe", "I think I am moving to other field"));
            video3.Comments.Add(new Comment("Ivan", "We are all cooked"));

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            foreach (Video video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length: " + video.Length + " seconds");
                Console.WriteLine("Number of comments: " + video.GetCommentCount());
                Console.WriteLine("Comments:");
                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}
