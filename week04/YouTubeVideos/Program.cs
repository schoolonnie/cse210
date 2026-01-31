using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos & comments with lists for each
        Video video1 = new Video("The Best Video Ever", "Amanda Hugginkis", 120);
        Video video2 = new Video("The REAL Best Video Ever", "Ahmed Adoudi", 180);
        Video video3 = new Video("FOR REAL THE BEST VIDEO", "Ollie Tabooger", 90);

        Comment comment1a = new Comment("JameBonn", "This is the best video ever!");
        Comment comment1b = new Comment("CommentManDan", "I learned so much from this. Truly the best video.");
        Comment comment1c = new Comment("ILiveOnYouTubeGuy", "Can't wait to see MORE! POST MORE!");

        Comment comment2a = new Comment("ViewerOfVideos", "Not as good as Amanda's, but still pretty great.");
        Comment comment2b = new Comment("CritiqueQueen", "No where NEAR the best video ever. DISSAPOINTED!");
        Comment comment2c = new Comment("RandomGuyKai", "I don't care what the haters say, Adoudi. This is the best video ever.");

        Comment comment3a = new Comment("FanaticFan", "BETTER THAN AMANDA'S VIDEO! WOW!");
        Comment comment3b = new Comment("MovieBuff99", "This video blew me away. Incredible work!");
        Comment comment3c = new Comment("CasualDudeFood", "Pretty good, but needs more food.");

        List<Video> videos = new List<Video> { video1, video2, video3 };

        List<Comment> commentsForVideo1 = new List<Comment> { comment1a, comment1b, comment1c };
        List<Comment> commentsForVideo2 = new List<Comment> { comment2a, comment2b, comment2c };
        List<Comment> commentsForVideo3 = new List<Comment> { comment3a, comment3b, comment3c };
        
        // Add comments to each video
        foreach (var comment in commentsForVideo1)
        {
            video1.AddComment(comment);
        }
        foreach (var comment in commentsForVideo2)
        {
            video2.AddComment(comment);
        }
        foreach (var comment in commentsForVideo3)
        {
            video3.AddComment(comment);
        }
        
        // Display video info with comments
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(); // Add a blank line to make it easier to read
        }
    }
}