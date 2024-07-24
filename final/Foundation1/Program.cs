using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = [];
        Random ran = new();
        int _videoCounter = 0;

        Console.Clear();

        for(int i = 1; i <= 4; i++)
        {
            Video video = new($"Cool Video{i}", $"George{i}", ran.Next(100));
            _videos.Add(video);
        }

        foreach(Video video in _videos)
        {
            _videoCounter++;
            for(int i = 1; i <= ran.Next(3, 5); i++)
            {
                video.AddComment($"Bob{i}", $"This is Bob{i}'s comment for video{_videoCounter}");
            }
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}