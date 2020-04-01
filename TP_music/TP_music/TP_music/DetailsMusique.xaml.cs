using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_music
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsMusique : ContentPage
    {
        private Musique musique;
        public DetailsMusique(Musique musique)
        {
            InitializeComponent();
            this.musique = musique;
            this.pochette.Source = musique.Pochette; 
            this.titre.Text = musique.Titre; 
            this.auteur.Text = musique.Auteur; 
            this.duree.Text = musique.Duree + "s";
        }
    }
}