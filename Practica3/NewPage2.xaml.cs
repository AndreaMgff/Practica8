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
    /// Cambiamos los valores de la pagina secundaria Detalles.xaml pudiendo reutilizarla con todas las demas paginas del menu. En este caso a�adimos la informacion del Fenrir
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DetallesBTN (object sender, EventArgs e)
	{
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Fenrir solo era un cachorro, pero conforme se aliment� y empez� a crecer, lleg� un punto que fue imposible controlarlo. Los �sir decidieron retenerlo en Asgard, para mantenerlo vigilado, pero nadie ten�a el valor suficiente para cuidar de �l. Al ver el enorme tama�o que estaba alcanzando, decidieron atarlo. Dos veces fallaron los dioses en su intento por apresarlo: primero con la cadena Leding y despu�s con la todav�a m�s fuerte Droma, que Fenrir se dej� poner, y de las que se liber� f�cilmente. Entonces, los dioses acudieron a los enanos, que fabricaron la cadena Gleipnir, que era sedosa como un lazo pero estaba forjada con seis ingredientes m�gicos: una pisada de gato, una barba de mujer, el aliento de un pez, las ra�ces de una monta�a, los nervios de un oso y la saliva de un p�jaro. Llevaron la cadena a Fenrir, que al saber que estaba compuesta por ingredientes m�gicos, se neg� a coloc�rsela. Los Aesir le prometieron que, si no lograba romper la cadena, lo liberar�an, porque ya no les parecer�a una amenaza, pero Fenrir, sospechando, volvi� a negarse, pero accedi� a pon�rsela si alguno de los dioses aceptaba poner una mano en su hocico, como prueba de buena fe. Solamente Tyr, sobrino de Od�n, se present� como voluntario para poner la mano en las fauces del lobo. Entonces, Fenrir permiti� que lo ataran, pero al ver que no lograba liberarse, cerr� el hocico y se qued� con la mano de Tyr." }
        });
    }
    /// <summary>
    ///Indica cual es el color de fondo de la pagina en base al que se ha guardado en la pagina de configuraci�n
    /// </summary>
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var savedColor = Preferences.Get("BackgroundColor", "#000000");
        this.BackgroundColor = Color.FromArgb(savedColor);
    }
}