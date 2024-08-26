using System;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class PedidosBD : ContentPage
    {
        public PedidosBD()
        {
            InitializeComponent();
        }

        	private void Voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }
     private void ad(object sender, EventArgs args)
	{
		Application.Current.MainPage = new PedidosCriar();
   }
    }
}