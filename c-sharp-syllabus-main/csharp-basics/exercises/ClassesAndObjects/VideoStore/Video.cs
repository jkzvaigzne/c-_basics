namespace VideoStore
{
    public class Video
    {
        public string Title { get; }
        public bool IsCheckedOut { get; private set; }
        public double AverageUserRating { get; private set; }
        private int totalRatings;
        private int peopleLiked;

        public Video(string title)
        {
            Title = title;
        }

        public void Rent() => IsCheckedOut = true;

        public void Return() => IsCheckedOut = false;

        public void LeaveARating(double rating)
        {
            totalRatings++;
            AverageUserRating = (totalRatings * AverageUserRating + rating) / totalRatings;

            if (rating > 3)
            {
                peopleLiked++;
            }
        }

        public double GetPercentagesOfPeopleWhoLikedVideo() =>
            totalRatings > 0 ? (peopleLiked / (double)totalRatings) * 100 : 0;
    }
}
