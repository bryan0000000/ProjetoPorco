namespace ProjetoPorco;

public partial class Fornecedores : ContentPage
{
	int count = 0;

	public Fornecedores()
	{
		InitializeComponent();
	}

	 private void bsilk(object sender, EventArgs args)
	{
		Application.Current.MainPage = new ClienteBD();
    }   
     private void bcostura(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CosturaBD();
   }
    private void bbordado(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PedidosBD();
   }
    private void bcorte(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PedidosBD();
   }
    private void bre(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage ();
		
		
   }

}