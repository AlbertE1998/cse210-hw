using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Learn C# in 15 Minutes",
            "Code Academy",
            900);

        Video video2 = new Video(
            "Top 10 Gaming Moments",
            "Game Central",
            1200);

        Video video3 = new Video(
            "How to Bake Chocolate Chip Cookies",
            "Kitchen Corner",
            600);

        Video video4 = new Video(
            "The Solar System Explained",
            "Science Daily",
            1500);

        video1.AddComment(new Comment("Alice", "This tutorial was amazing!"));
        video1.AddComment(new Comment("Bob", "Very easy to follow."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));

        video2.AddComment(new Comment("David", "Number 3 was my favorite!"));
        video2.AddComment(new Comment("Emma", "I laughed so hard."));
        video2.AddComment(new Comment("Frank", "Can't wait for another video."));

        video3.AddComment(new Comment("Grace", "My cookies turned out great!"));
        video3.AddComment(new Comment("Henry", "Very helpful instructions."));
        video3.AddComment(new Comment("Isabella", "I added walnuts and loved it!"));

        video4.AddComment(new Comment("Jack", "Science is awesome!"));
        video4.AddComment(new Comment("Karen", "I learned a lot."));
        video4.AddComment(new Comment("Liam", "Please make one about black holes!"));

        List<Video> videos = new List<Video>()
        {
            video1,
            video2,
            video3,
            video4
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine("\n---------------------------------\n");
        }
    }
}