using System;
using System.Collections.Generic;

namespace VideoStore
{
    class Program
    {
        private static VideoStore _videoStore = new VideoStore();

        public static void Main(string[] args)
        {
            while (true)
            {
                DisplayOptions();
                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        _videoStore.ListAllVideos();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void DisplayOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Choose the operation you want to perform:");
            Console.WriteLine("0: EXIT");
            Console.WriteLine("1: Fill video store");
            Console.WriteLine("2: Rent video");
            Console.WriteLine("3: Return video");
            Console.WriteLine("4: List inventory");
        }

        private static void FillVideoStore()
        {
            do
            {
                if (GetYesOrNoInput("Do You want to add video? (y or n)") != 'y')
                {
                    break;
                }

                string movieName = GetValidUserInput("Enter movie name: ");
                _videoStore.AddVideo(movieName);

            } while (true);
        }

        private static void RentVideo()
        {
            string videoToRent = GetValidUserInput("Enter name of movie you want to rent: ");

            if (IsVideoAvailable(videoToRent, false))
            {
                _videoStore.RentVideo(videoToRent);

                double percentileOfLikes = _videoStore.GetPercentageOfLikes(videoToRent);
                Console.WriteLine(percentileOfLikes > 50 ? $"Good choice, this video is liked by {percentileOfLikes}%" : $"You rented {videoToRent}");
            }
            else
            {
                Console.WriteLine($"{videoToRent} is not found!");
            }
        }

        private static void ReturnVideo()
        {
            string videoToReturn = GetValidUserInput("Enter name of video you want to return: ");

            if (IsVideoAvailable(videoToReturn, true))
            {
                _videoStore.ReturnVideo(videoToReturn);

                if (GetYesOrNoInput("Do you want to leave a rating? (y or n)") == 'y')
                {
                    double userRating = GetValidUserRating("Enter your rate (0 - 5): ");
                    _videoStore.GiveRating(videoToReturn, userRating);
                }
            }
            else
            {
                Console.WriteLine("Name not valid!");
            }
        }

        static char GetYesOrNoInput(string message)
        {
            char userInput = ' ';

            while (true)
            {
                Console.WriteLine(message);
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (userInput == 'y' || userInput == 'n')
                {
                    return userInput;
                }
            }
        }

        static string GetValidUserInput(string message)
        {
            string input;

            while (true)
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
            }
        }

        static double GetValidUserRating(string message)
        {
            double rating;

            while (true)
            {
                Console.WriteLine(message);

                if (double.TryParse(Console.ReadLine(), out rating) && rating >= 0 && rating <= 5)
                {
                    return rating;
                }
            }
        }

        static bool IsVideoAvailable(string videoName, bool isCheckedOut) =>
            _videoStore.GetVideoList().Exists(video => video.Title == videoName && video.IsCheckedOut == isCheckedOut);
    }
}
