using System.Collections.Generic;
using TP_xamarin4.Models;

namespace TP_xamarin4.Services
{
    public class TwitterService : ITwitterService
    {
        public bool authenticate(string identifiant, string password)
        {
            if (identifiant.Equals("root") && password.Equals("password")){
                return true; 
            }

            return false;
        }

        public List<Tweet> getTweets()
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet()
            {
                createdAt = "Thu Apr 01 14:20:10 +0000 2020",
                text="Lorem ipsum ...",
                userName = "Twitter API",
                userPseudo = "twitterapi" 
            });

            tweets.Add(new Tweet()
            {
                createdAt = "Fri Apr 05 17:00:00 +0000 2020",
                text="Lorem ipsum2 ...",
                userName = "Twitter API",
                userPseudo = "twitterapi"
            });

            return tweets;
        }
    }
}
