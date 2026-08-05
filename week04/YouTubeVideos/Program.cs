using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("10 C# Tips You Wish You Knew Earlier", "CodeWithMosh", 742);
        video1.AddComment(new Comment("DevDave", "This changed how I write code completely!"));
        video1.AddComment(new Comment("SharpSally", "Tip number 7 blew my mind. Great content."));
        video1.AddComment(new Comment("NoviceNate", "Finally someone explains this clearly. Thanks!"));
        video1.AddComment(new Comment("ProPriya", "Been coding for 5 years and still learned something new."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Build a REST API in 30 Minutes", "TraversyMedia", 1820);
        video2.AddComment(new Comment("BackendBob", "Best REST API tutorial I've found. Subscribed!"));
        video2.AddComment(new Comment("FullStackFiona", "Followed along perfectly. Works great."));
        video2.AddComment(new Comment("APIAndy", "Could you do a follow-up with authentication?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Object-Oriented Programming in 7 Minutes", "ProgrammingWithMosh", 420);
        video3.AddComment(new Comment("ClassyCarla", "OOP finally makes sense to me. Thank you!"));
        video3.AddComment(new Comment("AbstractAlex", "Clear, concise, and well-paced. Loved it."));
        video3.AddComment(new Comment("PolyPete", "Wish my professor explained it this well."));
        video3.AddComment(new Comment("EncapElla", "Watched this three times. So helpful!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Git and GitHub Crash Course for Beginners", "TechWorld", 2160);
        video4.AddComment(new Comment("CommitKing", "I finally understand branching. Life changing!"));
        video4.AddComment(new Comment("MergeQueen", "The merge conflict explanation was spot on."));
        video4.AddComment(new Comment("ForkFrank", "Best Git video out there, no question."));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}