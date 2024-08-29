namespace ProjetoPorco;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	 private void botaoclientes(object sender, EventArgs args)
	{
		Application.Current.MainPage = new ClienteBD();
    }   
     private void botaoPedidos(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PedidosBD();
   }
   private void botaofornecedor(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Fornecedores();
   }

}