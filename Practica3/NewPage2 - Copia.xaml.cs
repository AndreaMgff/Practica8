namespace Practica3;

public partial class NewPage2 : ContentPage //completa
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private void DetallesBTN (object sender, EventArgs e)
	{
        Navigation.PushAsync(new Detalles
        {
            BindingContext = new Class1 { Texto = "Fenrir es un lobo gigante y feroz que desempeña un papel crucial en el Ragnarök, el fin del mundo en la mitología nórdica. Según la profecía, Fenrir se liberará y desencadenará el caos en el mundo." }
        });
    }
}