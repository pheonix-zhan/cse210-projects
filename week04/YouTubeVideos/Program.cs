using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learn C#", "CodeMaster", 600);
        v1.AddComments(new Comment("Sandra", "Very helpful!"));
        v1.AddComments(new Comment("James", "Clear explanation."));
        v1.AddComments(new Comment("Aisha", "Loved it."));
        videos.Add(v1);

        Video v2 = new Video("HTML & CSS", "WebGuru", 900);
        v2.AddComments(new Comment("Brian", "Nice examples."));
        v2.AddComments(new Comment("Lucy", "Easy to follow."));
        v2.AddComments(new Comment("Mark", "Great lesson."));
        videos.Add(v2);

        Video v3 = new Video("JavaScript Basics", "DevWorld", 1200);
        v3.AddComments(new Comment("Kevin", "Well explained."));
        v3.AddComments(new Comment("Nina", "Finally understood JS."));
        v3.AddComments(new Comment("Paul", "Thanks!"));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetVideoLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberofComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}