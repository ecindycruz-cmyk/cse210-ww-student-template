using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create Videos
        Video video1 = new Video("Video 1", "Author 1", 360);
        Video video2 = new Video("Video 2", "Author 2", 420);
        Video video3 = new Video("Video 3", "Author 3", 300);
        Video video4 = new Video("Video 4", "Author 4", 480);

        //Add comments to each video.
        video1.AddComment(new Comment("Persona 1", "I liked the video"));
        video1.AddComment(new Comment("Persona 2", "I found the video interesting"));
        video1.AddComment(new Comment("Persona 3", "I loved the end"));

        video2.AddComment(new Comment("Persona 4", "I liked the music of the video"));
        video2.AddComment(new Comment("Persona 5", "It was fun"));
        video2.AddComment(new Comment("Persona 6", "I loved the animation"));

        video3.AddComment(new Comment("Persona 7", "I liked the history"));
        video3.AddComment(new Comment("Persona 8", "I found it exciting"));
        video3.AddComment(new Comment("Persona 9", "I loved the end of the history"));

        video4.AddComment(new Comment("Persona 10", "I liked the edition"));
        video4.AddComment(new Comment("Persona 11", "I found it professional"));
        video4.AddComment(new Comment("Persona 12", "I liked the content"));

        //Add the videos to a List.

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        //Show information of each video.

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} segundos");
            Console.WriteLine($"Number of comments: {video.GetNumberComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" -{comment.GetNamePerson()}: {comment.GetTextComment()}");
            }
            Console.WriteLine();

        }

    }

    
    
}