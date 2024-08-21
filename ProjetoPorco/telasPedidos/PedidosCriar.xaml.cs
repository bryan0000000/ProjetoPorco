using Controles;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class PedidosCriar : ContentPage
    {
        PedidosControle pedidosControle = PedidosControle;
        public PedidosCriar()
        {
         InitializeComponent();
        }

        private void OnCadastrarClienteClicked (object sender, EventArgs e)
        {
             
               // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
               var Pedidos = new Modelos.Pedidos();
               if (!String.IsNullOrEmpty(IdLabel.Text))
                 Pedidos.id      = int.Parse(IdLabel.Text);
               else
                Pedidos.id       = 0;
               Pedidos.Nome      = nNome.Text;
               Pedidos.Email     = nEmail.Text;
               Pedidos.Telefone  = nTelefone.Text;
             
         
               // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
                pedidosControle.CriarOuAtualizar(Pedidos);
               // Mostra a mensagem de sucesso
                  DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
             
        }
    }

  private void b145(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }


}