using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Practica3
{
    public partial class ControlPage : ContentPage
    {
        int count = 0;

        public ControlPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Proceso para autenticar usando la huella
        /// Si la autenticación funciona te lleva a la pantalla principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ClickedHuella(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration("Autenticacion", " Autenticacion por Huella");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request); 
            if (result.Authenticated)
            {
                await DisplayAlert("Autenticado", "Se ha autenticado correctamente", "Cancelar");
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Fallo de Autenticacion", "No se ha autenticado correctamente!", "Cancelar");
            }
        }
        /// <summary>
        /// Comprueba el nombre de usuario y su contraseña y si son correctos te lleva a la pantalla principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = entryUsername.Text;
            string password = entryPassword.Text;

            if (username == "admin" && password == "1234")
            {
                await DisplayAlert("Autenticado", "Inicio de sesión correcto", "OK");
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Fallo de Autenticacion", "Usuario o contraseña incorrectos", "Intentar de nuevo");
            }
        }
    }
}
