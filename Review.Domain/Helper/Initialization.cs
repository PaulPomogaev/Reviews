using Review.Domain.Models;

namespace Review.Domain.Helper
{
    public static class Initialization
    {
        private static readonly Random _random = new();

        private const string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public static Models.Review[] SetReviews()
        {
            var count = 100;
            List<Models.Review> result = new List<Models.Review>(count);
            for (int i = 1; i <= count; i++)
            {
                Models.Review feedback = CreateReview(i);
                result.Add(feedback);
            }
            return result.ToArray();
        }

        public static Models.Review CreateReview(int reviewId)
        {
            return new Models.Review()
            {
                Id = reviewId,
                CreateDate = DateTime.Now.AddDays(_random.Next(-100, 0)),
                Grade = _random.Next(0, 6),
                ProductId = _random.Next(1, 10),
                Text = LoremIpsum.Substring(0, _random.Next(20, 100)),
                UserId = _random.Next(1, 10), 
                RatingId = _random.Next(1, 10),
                Status = (Status)_random.Next(0, 3)
            };
        }

        public static Rating[] SetRatings()
        {
            var count = 100;
            List<Rating> result = new List<Rating>(count);
            for (int i = 1; i <= count; i++)
            {
                Rating rating = CreateRating(i);
                result.Add(rating);
            }
            return result.ToArray();
        }

        public static Rating CreateRating(int ratingId)
        {
            var sampleCount = _random.Next(1, 10);
            var reviewSamples = new List<Models.Review>(sampleCount);
            for (int k = 1; k <= sampleCount; k++)
            {
                reviewSamples.Add(CreateReview(k));
            }

            var reviewsAverage = reviewSamples.Select(x => x.Grade).Average();

            var rating = new Rating()
            {
                Id = ratingId,
                CreateDate = DateTime.Now.AddDays(_random.Next(-100, 0)),
                ProductId = _random.Next(1, 10),
                Grade = Math.Round(reviewsAverage, 2)
            };
            return rating;
        }

        public static Login[] SetLogins()
        {
            var results = new List<Login>();
            var login = new Login()
            {  
                Id = 1,
                UserName = "admin", 
                Password = "admin" 
            };
            results.Add(login);
            return results.ToArray();
        }
    }
}
