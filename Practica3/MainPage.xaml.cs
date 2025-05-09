namespace Practica3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //public Color BackgroundColor { get; set; }
        public MainPage()
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
    }

}
