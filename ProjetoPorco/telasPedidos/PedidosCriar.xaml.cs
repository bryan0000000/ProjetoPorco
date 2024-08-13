using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class PedidosCriar : ContentPage
    {
        public PedidosCriar()
        {
         InitializeComponent();
        }

        private void OnCadastrarClienteClicked (object sender, EventArgs e)
        {
           string nome = Nome.Text;
           string telefone = nTelefone.Text;
           string email = nEmail.Text;

             //Lógica para ;cadastrar o; cliente;
            DisplayAlert("ClienteCadastrado", $"Nome: {nome}\nTelefone: {telefone}\nEmail: {email}", "OK");
        }
    }
}