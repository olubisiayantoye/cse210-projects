using System;
using System.Collections.Generic;
/* Brigham Young University–Idaho
         Olubisi Ayantoye
       Foundation Program #1: Abstraction with YouTube Videos */
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("How to Code in C#", "John Doe", 600);
        Video video2 = new Video("Learn Data Structures", "Jane Smith", 1200);
        Video video3 = new Video("Understanding Algorithms", "Alan Turing", 900);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Loved the explanation."));

        video2.AddComment(new Comment("Dave", "Clear and concise."));
        video2.AddComment(new Comment("Eve", "Thanks for the help!"));

        video3.AddComment(new Comment("Frank", "Mind-blowing concepts."));
        video3.AddComment(new Comment("Grace", "I finally get algorithms!"));
        video3.AddComment(new Comment("Heidi", "More videos like this, please."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            
        }
    }
}
