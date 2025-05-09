namespace Practica3;

public partial class NewPage4 : ContentPage
{
    /// <summary>
    /// Inicializa la pagina 
    /// </summary>
	public NewPage4()
	{
		InitializeComponent();
    }
    /// <summary>
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso añadimos la informacion del dragon.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "El dragón es un animal mitológico presente en una gran variedad de culturas a lo largo de todo el mundo, aunque sin duda destaca en la cultura asiática. Se representa generalmente como una serpiente alargada con un cuerpo sin patas y aunque su apariencia puede variar, a menudo se le describe con escamas brillantes y de colores vivos, como azul, rojo, amarillo o verde.\r\n\r\nSuele tener connotaciones de poder, nobleza, buena fortuna y prosperidad, a diferencia del concepto tradicional occidental, que suele tomarlo como animales feroces.\r\n\r\nAl igual que ocurría con el unicornio, la figura de este animal mitológico se mantuvo a lo largo del tiempo porque se creían hallar restos de ellos: los fósiles. Muchos fósiles, sobre todo de grandes mamíferos del cuaternario, eran confundidos con huesos de dragones, lo que reforzaba la idea de su existencia.El dragón es un animal mitológico presente en una gran variedad de culturas a lo largo de todo el mundo, aunque sin duda destaca en la cultura asiática. Se representa generalmente como una serpiente alargada con un cuerpo sin patas y aunque su apariencia puede variar, a menudo se le describe con escamas brillantes y de colores vivos, como azul, rojo, amarillo o verde.\r\n\r\nSuele tener connotaciones de poder, nobleza, buena fortuna y prosperidad, a diferencia del concepto tradicional occidental, que suele tomarlo como animales feroces.\r\n\r\nAl igual que ocurría con el unicornio, la figura de este animal mitológico se mantuvo a lo largo del tiempo porque se creían hallar restos de ellos: los fósiles. Muchos fósiles, sobre todo de grandes mamíferos del cuaternario, eran confundidos con huesos de dragones, lo que reforzaba la idea de su existencia." }
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