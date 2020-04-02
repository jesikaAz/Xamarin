using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TP_xamarin4.Models;
using TP_xamarin4.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_xamarin4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        ITwitterService twitterService = new TwitterService();

        ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();

        public TweetPage()
        {
            InitializeComponent();

            List<Tweet> tweets = twitterService.getTweets();

            foreach (Tweet tweet in tweets)
            {
                this.tweets.Add(tweet);
            }
            this.tweetsList.ItemsSource = tweets;
        }
    }
}