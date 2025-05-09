namespace Practica3;

public partial class Configuracion : ContentPage
{
    public Configuracion()
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
    /// Elimina todas las galerías guardadas y te muestra un mensaje confirmando que se guardo
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
    /// <summary>
    /// Cambia el color de fondo a negro y lo guarda 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnFondoNegroClicked(object sender, EventArgs e)
    {
        var color = "#000000";
        Preferences.Set("BackgroundColor", color);
        this.BackgroundColor = Color.FromArgb(color);
        DisplayAlert("Fondo negro", "Se ha cambiado el color de fondo", "OK");
    }
    /// <summary>
    /// Cambia el color de fondo a gris y lo guarda 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnFondoGrisClicked(object sender, EventArgs e)
    {
        Preferences.Set("BackgroundColor", "#919191");
        this.BackgroundColor = Color.FromArgb("#919191");
        DisplayAlert("Fondo Gris", "Se ha cambiado el color de fondo", "OK");
    }

}