using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TP_xamarin3
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Connection_Clicked(object sender, EventArgs e) 
        { 
            //Console.WriteLine("Connection is clicked");
            String identifiant = this.identifiant.Text; 
            String password = this.password.Text; 
            Boolean isRemember = this.remember.IsToggled;

            this.errorIdentifiant.IsVisible = false;
            this.errorPassword.IsVisible = false;

            bool errorExist = false;
            if (String.IsNullOrEmpty(identifiant) || identifiant.Length < 3)
            {
                errorExist = true;
                this.errorIdentifiant.IsVisible = true;
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                errorExist = true;
                this.errorPassword.IsVisible = true;
            }

            if (errorExist) { return; }
            this.tweets.IsVisible = true;
            this.forms.IsVisible = false;
            return;
        }
    }
}
