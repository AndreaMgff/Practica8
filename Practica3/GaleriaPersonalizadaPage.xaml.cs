using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Practica3
{
    public partial class GaleriaPersonalizadaPage : ContentPage
    {
        public GaleriaPersonalizadaPage()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Indica cual es el color de fondo de la pagina en base al que se ha guardado en la pagina de configuracion
        ///Tambien sirve para cargar si ya habia alguna galeria creada
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadGalleries();
            var savedColor = Preferences.Get("BackgroundColor", "#000000");
            this.BackgroundColor = Color.FromArgb(savedColor);
        }
        /// <summary>
        /// Carga las galerias que se han creado y crea un boton para cada una. Al pulsar uno de esos botones activa el método OnGalleryButtonClicked.
        /// </summary>
        private void LoadGalleries()
        {
            galleryStack.Children.Clear();

            var galleries = Preferences.Get("Galleries", string.Empty);
            var galleryList = string.IsNullOrEmpty(galleries)
                ? new List<string>()
                : galleries.Split(',').ToList();

            foreach (var galleryName in galleryList)
            {
                var button = new Button
                {
                    Text = galleryName
                };
                button.Clicked += OnGalleryButtonClicked;
                galleryStack.Children.Add(button);
            }
        }
        /// <summary>
        /// Método que carga los botones de los animales que se habian seleccionado en el botón de la galería que se ha pulsado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnGalleryButtonClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string galleryName = button.Text;

            var selectedAnimals = Preferences.Get(galleryName, string.Empty)
                                             .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                             .ToList();

            // Guardar en Preferences para que GaleriaPage pueda acceder
            Preferences.Set("CurrentGalleryAnimals", string.Join(",", selectedAnimals));

            await Shell.Current.GoToAsync("//GaleriaPage");
        }

    }

}
