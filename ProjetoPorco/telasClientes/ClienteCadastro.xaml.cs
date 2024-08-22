using Controles;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class ClienteCadastro : ContentPage
    {
        ClienteControle ClienteControle = new Controles.ClienteControle();
        public ClienteCadastro()
        {
         InitializeComponent();
        }

        private void OnCadastrarClienteClickeda (object sender, EventArgs e)
        {
             
               // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
               var Pedidos = new Modelos.Pedidos();
               if (!String.IsNullOrEmpty(IdLabel.Text))
                 Pedidos.id      = int.Parse(IdLabel.Text);
               else
                Pedidos.id       = 0;
               Pedidos.Nome      = cNome.Text;
               Pedidos.Telefone  = cTelefone.Text;
             
         
               // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
                ClienteControle.CriarOuAtualizar(Pedidos);
               // Mostra a mensagem de sucesso
                  DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
             
        }
    
      private void jotaov (object sender, EventArgs args)
     {
     	Application.Current.MainPage = new ClienteBD();
     }

    } 
}