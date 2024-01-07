using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videos = new List<Video>();

        public void AddVideo(string videoName) => _videos.Add(new Video(videoName));

        public void RentVideo(string videoName) => _videos.Find(v => v.Title == videoName && !v.IsCheckedOut)?.Rent();

        public void ReturnVideo(string videoName) => _videos.Find(v => v.Title == videoName && v.IsCheckedOut)?.Return();

        public void GiveRating(string videoName, double rating) => _videos.Find(v => v.Title == videoName)?.LeaveARating(rating);

        public void ListAllVideos() => _videos.ForEach(v => Console.WriteLine($"Video Title: {v.Title}. Video Rating: {v.AverageUserRating}. In stock: {v.IsCheckedOut}"));

        public double GetPercentageOfLikes(string videoName) => _videos.Find(v => v.Title == videoName)?.GetPercentagesOfPeopleWhoLikedVideo() ?? 0;

        public List<Video> GetVideoList() => _videos;
    }
}
