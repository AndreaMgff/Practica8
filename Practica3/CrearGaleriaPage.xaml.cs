using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;

namespace Practica3
{
    public partial class CrearGaleriaPage : ContentPage
    {
        public CrearGaleriaPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Indica cual es el color de fondo de la pagina en base al que se ha guardado en la pagina de configuracion
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var savedColor = Preferences.Get("BackgroundColor", "#000000");
            this.BackgroundColor = Color.FromArgb(savedColor);
        }
        /// <summary>
        /// Guarda una nueva galería personalizada con los animales seleccionados
        /// Actualiza la lista de galerías almacenadas en galeria personalizada y te muestra un mensaje confirmando que se guardo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnSaveGalleryClicked(object sender, EventArgs e)
        {
            List<string> selectedAnimals = new List<string>();

            if (checkBoxUnicornio.IsChecked)
                selectedAnimals.Add("Unicornio");
            if (checkBoxFenrir.IsChecked)
                selectedAnimals.Add("Fenrir");
            if (checkBoxFenix.IsChecked)
                selectedAnimals.Add("Fenix");
            if (checkBoxDragon.IsChecked)
                selectedAnimals.Add("Dragón");

            string galleryName = "GaleríaPersonalizada" + (Preferences.Get("GalleryCount", 0) + 1).ToString();
            int galleryCount = Preferences.Get("GalleryCount", 0);
            galleryCount++;
            Preferences.Set("GalleryCount", galleryCount);
            var galleries = Preferences.Get("Galleries", string.Empty);
            List<string> galleryList = string.IsNullOrEmpty(galleries) ? new List<string>() : new List<string>(galleries.Split(','));
            galleryList.Add(galleryName);
            Preferences.Set("Galleries", string.Join(",", galleryList));
            Preferences.Set(galleryName, string.Join(",", selectedAnimals));
            await DisplayAlert("Galería Guardada", "La nueva galería ha sido guardada correctamente.", "OK");
            await Shell.Current.GoToAsync("//GaleriaPersonalizadaPage");
        }
        /// <summary>
        ///  Elimina todas las galerías guardadas y te muestra un mensaje confirmando que se guardo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBorrarGaleriasClicked(object sender, EventArgs e)
        {
            BorrarGalerias();
            DisplayAlert("Galerías eliminadas", "Todas las galerías han sido eliminadas.", "OK");
        }
        /// <summary>
        /// Borra todas las galerías y sus datos 
        /// </summary>
        private void BorrarGalerias()
        {
            var galleries = Preferences.Get("Galleries", string.Empty);
            var galleryList = string.IsNullOrEmpty(galleries) ? new List<string>() : galleries.Split(',').ToList();
            foreach (var galleryName in galleryList)
            {
                Preferences.Remove(galleryName);
            }
            Preferences.Remove("Galleries");
            Preferences.Remove("GalleryCount");
        }
    }
}
