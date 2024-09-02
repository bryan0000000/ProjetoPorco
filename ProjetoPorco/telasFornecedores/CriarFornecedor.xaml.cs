using Controles;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class CriarFornecedor : ContentPage
    {
        FornecedorCrotroles FornecedorCrotroles = new Controles.FornecedorCrotroles();
        public CriarFornecedor()
        {
         InitializeComponent();
        }

      private void botaocriar (object sender, EventArgs e)
      {
           
             // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
             var Fornecedor = new Modelos.Fornecedor();
             if (!String.IsNullOrEmpty(IdLabel.Text))
               Fornecedor.id      = int.Parse(IdLabel.Text);
             else
             Fornecedor.id       = 0;
             Fornecedor.Nome      = fNome.Text;
             Fornecedor.Email     = fEmail.Text;
             Fornecedor.Telefone  = fTelefone.Text;
           
       
             // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
              FornecedorCrotroles.CriarOuAtualizar(Fornecedor);
             // Mostra a mensagem de sucesso
                DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
           
      }
    
      private void botaov (object sender, EventArgs args)
     {
     	Application.Current.MainPage = new MainPage();
     }
      private void Voltar12(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CosturaBD();
   }

    } 
}