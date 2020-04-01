using System;
using System.ComponentModel;
using TP_xamarin4.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TP_xamarin4
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterService twitterService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            String identifiant = this.identifiant.Text;
            String password = this.password.Text;
            Boolean isRemember = this.remember.IsToggled;

            this.errorIdentifiant.IsVisible = false;
            this.errorPassword.IsVisible = false;
            this.errorInternet.IsVisible = false;
            this.errorAuth.IsVisible = false;

            if (!isFormValid(identifiant, password))
            {
                return;
            }

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                this.errorInternet.IsVisible = true;
                return;
            }

            if (!this.twitterService.authenticate(identifiant, password))
            {
                this.errorAuth.IsVisible = true;
                return;
            }

            this.tweets.IsVisible = true;
            this.forms.IsVisible = false;
        }

        private bool isFormValid(String identifiant, String password)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(identifiant) || identifiant.Length < 3)
            {
                isValid = false;
                this.errorIdentifiant.IsVisible = true;
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                isValid = false;
                this.errorPassword.IsVisible = true;
            }

            return isValid;
        }
    }
}
