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
            BindingContext = new Class1 { Texto = "Fenrir es un lobo gigante y feroz que desempe�a un papel crucial en el Ragnar�k, el fin del mundo en la mitolog�a n�rdica. Seg�n la profec�a, Fenrir se liberar� y desencadenar� el caos en el mundo." }
        });
    }
}