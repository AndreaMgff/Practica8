namespace Practica3;

public partial class NewPage2 : ContentPage //completa
{
    /// <summary>
    /// Inicializa la pagina 
    /// </summary>
	public NewPage2()
	{
		InitializeComponent();
	}
    /// <summary>
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso añadimos la informacion del Fenrir
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN (object sender, EventArgs e)
	{
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Fenrir solo era un cachorro, pero conforme se alimentó y empezó a crecer, llegó un punto que fue imposible controlarlo. Los Æsir decidieron retenerlo en Asgard, para mantenerlo vigilado, pero nadie tenía el valor suficiente para cuidar de él. Al ver el enorme tamaño que estaba alcanzando, decidieron atarlo. Dos veces fallaron los dioses en su intento por apresarlo: primero con la cadena Leding y después con la todavía más fuerte Droma, que Fenrir se dejó poner, y de las que se liberó fácilmente. Entonces, los dioses acudieron a los enanos, que fabricaron la cadena Gleipnir, que era sedosa como un lazo pero estaba forjada con seis ingredientes mágicos: una pisada de gato, una barba de mujer, el aliento de un pez, las raíces de una montaña, los nervios de un oso y la saliva de un pájaro. Llevaron la cadena a Fenrir, que al saber que estaba compuesta por ingredientes mágicos, se negó a colocársela. Los Aesir le prometieron que, si no lograba romper la cadena, lo liberarían, porque ya no les parecería una amenaza, pero Fenrir, sospechando, volvió a negarse, pero accedió a ponérsela si alguno de los dioses aceptaba poner una mano en su hocico, como prueba de buena fe. Solamente Tyr, sobrino de Odín, se presentó como voluntario para poner la mano en las fauces del lobo. Entonces, Fenrir permitió que lo ataran, pero al ver que no lograba liberarse, cerró el hocico y se quedó con la mano de Tyr." }
        });
    }
    /// <summary>
    ///Indica cual es el color de fondo de la pagina en base al que se ha guardado en la pagina de configuración
    /// </summary>
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var savedColor = Preferences.Get("BackgroundColor", "#000000");
        this.BackgroundColor = Color.FromArgb(savedColor);
    }
}