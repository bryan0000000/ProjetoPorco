using Microsoft.Maui.Controls;

namespace PedidosCriar
{
    public partial class PedidosCriar : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClienteClicked (object sender, EventArgs e)
        {
           string nome = NomeEntry.Text;
           string telefone = TelefoneEntry.Text;
         string email = EmailEntry.Text;

             //Lógica para ;cadastrar o; cliente;
            DisplayAlert("ClienteCadastrado", $"Nome: {nome}\nTelefone: {telefone}\nEmail: {email}", "OK");
        }
    }
}



