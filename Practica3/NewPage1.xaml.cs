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
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso añadimos la informacion del unicornios
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles { BindingContext = new Class1 { Texto = "Los unicornios son animales mitológicos que estuvieron presentes en la cultura popular tanto antes como después de la Edad Media, aunque fue en esta época cuando vivió su auge. Están caracterizados por ser similares a un caballo blanco, aunque de su frente crecía un largo y fino cuerno.\r\n\r\nCuriosamente, al inicio se describía a este animal mitológico con la cabeza púrpura y ojos azules, característica que se fue perdiendo a lo largo de los siglos.\r\n\r\nHoy en día sabemos que estos animales no existen, aunque durante largos siglos así se creyó, principalmente debido a que sí existen animales con características parecidas, lo que confundió a las sociedades del pasado." }});
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