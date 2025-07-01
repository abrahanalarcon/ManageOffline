using Microsoft.Maui.Networking;


namespace ManageOffline
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            VerificarConexion();
        }

        private void VerificarConexion()
        {
            var estado = Connectivity.Current.NetworkAccess;

            if (estado != NetworkAccess.Internet)
            {
                lblEstadoConexion.Text = "Sin conexión a internet";
                DisplayAlert("Advertencia", "No tienes conexión a internet", "OK");
            }
            else
            {
                lblEstadoConexion.Text = "Conectado a internet";
            }
        }

        private void OnCheckConnectionClicked(object sender, EventArgs e)
        {
            VerificarConexion();
        }
    }

}
