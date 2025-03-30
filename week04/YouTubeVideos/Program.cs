using System;
using System.Collections.Generic;

// Comment class to track the commenter's name and the text of the comment
class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

// Video class to track the title, author, length, and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Get all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Format length in minutes and seconds
    public string GetFormattedLength()
    {
        int minutes = LengthInSeconds / 60;
        int seconds = LengthInSeconds % 60;
        return $"{minutes}:{seconds:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Video Tracking Program\n");

        // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Make Chocolate Chip Cookies", "BakingMaster", 485);
        video1.AddComment(new Comment("CookieLover42", "These are the best cookies I've ever made!"));
        video1.AddComment(new Comment("NewBaker2023", "Could you clarify the baking temperature?"));
        video1.AddComment(new Comment("SweetTooth", "I added extra chocolate chips and they turned out amazing!"));
        video1.AddComment(new Comment("GlutenFreeGuy", "Do you have a gluten-free version of this recipe?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10 Minute Full Body Workout", "FitnessFreak", 612);
        video2.AddComment(new Comment("GymNewbie", "This workout is perfect for beginners!"));
        video2.AddComment(new Comment("FitMom3", "I've been doing this every morning for a week. Great results!"));
        video2.AddComment(new Comment("ExerciseDoc", "Make sure to warm up properly before attempting these exercises."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Learn C# Programming in 30 Minutes", "CodeGeek", 1845);
        video3.AddComment(new Comment("ProgrammingStudent", "This tutorial helped me understand classes better than my professor!"));
        video3.AddComment(new Comment("SeniorDev", "Good introduction, but you should mention more about memory management."));
        video3.AddComment(new Comment("CodeNewbie", "Is there a follow-up video for more advanced topics?"));
        video3.AddComment(new Comment("PythonFan", "How does C# compare to Python for beginners?"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("DIY Home Office Setup", "InteriorDesigner101", 723);
        video4.AddComment(new Comment("WorkFromHome", "I implemented these ideas and my productivity has increased!"));
        video4.AddComment(new Comment("MinimalistLiving", "Love the clean design. What brand is that desk?"));
        video4.AddComment(new Comment("ErgoExpert", "Consider adding tips about proper chair height and monitor positioning."));
        videos.Add(video4);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.GetFormattedLength()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("\nComments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            
            Console.WriteLine(); // Extra line for spacing
        }
    }
}