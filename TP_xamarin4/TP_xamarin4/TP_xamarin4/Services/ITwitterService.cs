using System;
using System.Collections.Generic;
using TP_xamarin4.Models;

namespace TP_xamarin4.Services
{
    public interface ITwitterService
    {
        bool authenticate(String identifiant, String password); 
        List<Tweet> getTweets();
    }
}
