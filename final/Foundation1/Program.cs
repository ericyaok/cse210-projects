using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Youtube Video!");
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("How to make money", "Eric", 5);
        video1._commentsList.Add(new Comment("Ab", "great video"));
        video1._commentsList.Add(new Comment("Doe", "I agree"));
        video1._commentsList.Add(new Comment("Bel", "best video ever"));

        Video video2 = new Video("How to be happy", "Belinda", 7);
        video2._commentsList.Add(new Comment("Ab", "great video"));
        video2._commentsList.Add(new Comment("Doe", "I agree"));
        video2._commentsList.Add(new Comment("Bel", "best video ever"));

        Video video3 = new Video("How to study well", "Patrick", 8);
        video3._commentsList.Add(new Comment("Ab", "great video"));
        video3._commentsList.Add(new Comment("Doe", "I agree"));
        video3._commentsList.Add(new Comment("Bel", "best video ever"));

        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video._title}, Author: {video._author}, Length: {video._length}, Number of comments: {video._commentsList.Count}");
            Console.WriteLine("Comments");
            foreach (Comment comment in video._commentsList)
            {
                Console.WriteLine(comment.CommentRepresentation());
            }
        }

    }
}