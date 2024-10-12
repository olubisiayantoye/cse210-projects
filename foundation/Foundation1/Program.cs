using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
/* Brigham Young University–Idaho
         Olubisi Ayantoye
       Foundation Program #1: Abstraction with YouTube Videos */

        // Create a list to store Video objects
        List<Video> videos = new List<Video>();

        // Create Video 1 and add comments
        Video video1 = new Video("Learning C#", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "This was very helpful."));
        video1.AddComment(new Comment("Charlie", "Can you explain more about classes?"));
        videos.Add(video1);

        // Create Video 2 and add comments
        Video video2 = new Video("Introduction to Algorithms", "Jane Doe", 900);
        video2.AddComment(new Comment("David", "Awesome content!"));
        video2.AddComment(new Comment("Eve", "This made algorithms easier to understand."));
        video2.AddComment(new Comment("Frank", "Thanks for sharing!"));
        videos.Add(video2);

        // Create Video 3 and add comments
        Video video3 = new Video("Mastering Python", "Samuel Green", 750);
        video3.AddComment(new Comment("George", "Fantastic explanation."));
        video3.AddComment(new Comment("Hannah", "Very insightful!"));
        video3.AddComment(new Comment("Isabel", "Looking forward to more videos."));
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}

// Video class
class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    // Constructor for Video class
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Method to display video information and comments
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}

// Comment class
class Comment
{
    private string _name;
    private string _text;

    // Constructor for Comment class
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to get the name of the commenter
    public string GetName()
    {
        return _name;
    }

    // Method to get the comment text
    public string GetText()
    {
        return _text;
    }
}
