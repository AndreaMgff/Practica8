namespace Practica3;

public partial class NewPage3 : ContentPage
{
    /// <summary>
    /// Inicializa la pagina 
    /// </summary>
	public NewPage3()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso añadimos la informacion del fénix.
    /// </summary>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "El fénix es un ave mítica que cada vez que muere su cuerpo es consumido por el fuego y luego resurge de las cenizas.\r\n\r\nEsta metáfora sobre la resiliencia no parece tener una base en la biodiversidad animal de nuestro planeta, pero sí podemos encontrar un animal al que le pasa este proceso de renacimiento: la medusa Turritopsis nutricula, que tiene la particularidad de poder rejuvenecer una y otra vez." }
        });
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