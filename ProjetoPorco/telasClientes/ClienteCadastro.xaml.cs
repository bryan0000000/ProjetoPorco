using Controles;
using Microsoft.Maui.Controls;


namespace ProjetoPorco
{
    public partial class ClienteCadastro : ContentPage
    {
  
        PedidosControle PedidosControle = new Controles.PedidosControle();
        public ClienteCadastro()
        {
         InitializeComponent();
        }
      
         protected override void OnAppearing()
  {
    var Pedidos = new Modelos.Pedidos();
    base.OnAppearing();

    if (Pedidos != null)
    {
      IdLabel.Text        = Pedidos.id.ToString();
      cNome.Text      = Pedidos.Nome;
      cTelefone.Text  = Pedidos.Telefone;
     
    } }
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
                PedidosControle.CriarOuAtualizar(Pedidos);
               // Mostra a mensagem de sucesso
                  DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
             
        }
    
      private void jotaov (object sender, EventArgs args)
     {
     	Application.Current.MainPage = new ClienteBD();
     }
     
      // Método para limpar os dados da Entry
  private async void OnApagarClienteClicked(object sender, EventArgs e)
  {
     var Pedidos = new Modelos.Pedidos();
    // Verifica se estamos editando um cliente ou criando um cliente
    // Se estiver criando, não se pode apagar, já que não se tem um `cliente.Id`
    if (Pedidos == null || Pedidos.id < 1)
      await DisplayAlert("Erro", "Nenhum cliente para excluir", "ok");
    else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse cliente?","Excluir Cliente","cancelar")) // Caso o usuário tocar no Botão "Excluir Cliente"
    {
      // Apaga do Banco de Dados
      PedidosControle.Apagar(Pedidos.id);
      // Volta para a tela de Lista
      // Esse código abaixo pode ser um:
      // await NavigationPage.PopAsync();
      // Se você veio pra cá com um 
      // await Navigation.PushAsync(new CadastroClientePage);
      Application.Current.MainPage = new ClienteBD(); 
    }
  }





    } 
}
