using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;

namespace Practica3
{
    public partial class GaleriaPage : ContentPage
    {
        public GaleriaPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Indica cual es el color de fondo de la pagina en base al que se ha guardado en la pagina de configuracion
        ///Tambien sirve para cargar si ya habia alguna galeria creada
        ///En este caso tambien muestra los animales si no se ha cargado una galeria personalizada
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            animalStack.Children.Clear();
            var savedColor = Preferences.Get("BackgroundColor", "#000000");
            this.BackgroundColor = Color.FromArgb(savedColor);
            string storedAnimals = Preferences.Get("CurrentGalleryAnimals", string.Empty);

            string[] animalsToShow = string.IsNullOrEmpty(storedAnimals)
                ? new[] { "Unicornio", "Fenrir", "Fenix", "Dragón" }
                : storedAnimals.Split(',');
            foreach (var animal in animalsToShow)
            {
                var button = new Button
                {
                    Text = animal
                };
                button.Clicked += OnAnimalButtonClicked;
                animalStack.Children.Add(button);
            }
            Preferences.Remove("CurrentGalleryAnimals");
        }
        /// <summary>
        /// Navega a la página del animal seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnAnimalButtonClicked(object sender, EventArgs e)
        {
            string animal = ((Button)sender).Text;
            string route;
            if (animal == "Unicornio")
            {
                route = "//NewPage1";
            }
            else if (animal == "Fenrir")
            {
                route = "//NewPage2";
            }
            else if (animal == "Fenix")
            {
                route = "//NewPage3";
            }
            else if (animal == "Dragón")
            {
                route = "//NewPage4";
            }
            else
            {
                route = null;
            }

            if (!string.IsNullOrEmpty(route))
            {
                await Shell.Current.GoToAsync(route);
            }
        }
    }
}
