using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace TP_music
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Musique> musiques = new ObservableCollection<Musique>();
        public MainPage()
        {
            InitializeComponent();

            this.musiques.Add(new Musique { Titre = "Welcome to the Jungle", Auteur = "Guns n' Roses", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://img.discogs.com/TTvCdOfRi_fxLDTGFnB3oNUCcUo=/fitin/600x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-25995981458343786-9998.jpeg.jpg")) }); 
            this.musiques.Add(new Musique { Titre = "Rock You Like a Hurricane", Auteur = "Scorpion", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/en/thumb/b/b6/Rock_You_Like_a_Hurricane_by_Scorpions_Europea n_artwork_German_release.jpeg/220pxRock_You_Like_a_Hurricane_by_Scorpions_European_artwork_German_release.jpeg")) }); 
            this.musiques.Add(new Musique { Titre = "Kashmir", Auteur = "Led Zeppelin", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://static.hotmixradio.fr/wp-content/uploads/led-zeppelin-kashmir-live460x460.jpg")) }); 
            this.musiques.Add(new Musique { Titre = "Gimme Shelter", Auteur = "The Rolling Stones", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://images-na.ssl-images-amazon.com/images/I/51zMQgpp8L._SY445_.jpg")) }); 
            this.musiques.Add(new Musique { Titre = "Back in Black", Auteur = "AC/DC", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://images-na.ssl-images-amazon.com/images/I/61sJIfuUSiL._SL1500_.jpg")) }); 
            this.musiques.Add(new Musique { Titre = "All Along the Watchtower", Auteur = "Jimmy Hendrix", Durée = 180, Pochette = ImageSource.FromUri(new Uri("https://img.discogs.com/iZjJevL_oCH-iL7u0jhBWM_v_yw=/fitin/595x600/filters:strip_icc():format(jpeg):mode_rgb():quality(90)/discogs-images/R-17409641384158788-7761.jpeg.jpg")) });

            this.ListeMusiques.ItemsSource = this.musiques;
        }

        private async void ListeMusiques_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e) {
            var musique = (Musique)ListeMusiques.SelectedItem; 
            await Navigation.PushAsync(new DetailsMusique(musique));
        }
    }
}
