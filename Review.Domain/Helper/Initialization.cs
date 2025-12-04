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
            var reviews = new List<Models.Review>();
            for (int i = 1; i <= count; i++)
            {
                var review = new Models.Review()
                {
                    Id = i,
                    CreateDate = DateTime.Now.AddDays(_random.Next(-100, 0)),
                    Grade = _random.Next(1, 6), 
                    ProductId = _random.Next(1, 10),
                    Text = LoremIpsum.Substring(0, _random.Next(20, 100)),
                    UserId = _random.Next(1, 10),
                    Status = (Status)_random.Next(0, 3),
                    
                };
                reviews.Add(review);
            }
          
            return reviews.ToArray();
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
