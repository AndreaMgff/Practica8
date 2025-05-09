namespace Practica3;

public partial class NewPage1 : ContentPage //completa
{
    /// <summary>
    /// Inicializa la pagina 
    /// </summary>
    public NewPage1()
    {
        InitializeComponent();
    }
    /// <summary>
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso a�adimos la informacion del unicornios
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Class1 { Texto = "Los unicornios son animales mitol�gicos que estuvieron presentes en la cultura popular tanto antes como despu�s de la Edad Media, aunque fue en esta �poca cuando vivi� su auge. Est�n caracterizados por ser similares a un caballo blanco, aunque de su frente crec�a un largo y fino cuerno.\r\n\r\nCuriosamente, al inicio se describ�a a este animal mitol�gico con la cabeza p�rpura y ojos azules, caracter�stica que se fue perdiendo a lo largo de los siglos.\r\n\r\nHoy en d�a sabemos que estos animales no existen, aunque durante largos siglos as� se crey�, principalmente debido a que s� existen animales con caracter�sticas parecidas, lo que confundi� a las sociedades del pasado." }});
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