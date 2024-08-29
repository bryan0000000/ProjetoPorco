namespace ProjetoPorco;

public partial class CosturaBD : ContentPage
{
	int count = 0;

	public CosturaBD()
	{
		InitializeComponent();
	}

    private void bvota(object sender, EventArgs args)
	{
		Application.Current.MainPage = new Fornecedores();
   }
   private void bcriarfornecedor(object sender, EventArgs args)
	{
		Application.Current.MainPage = new CriarFornecedor();
   }
}

