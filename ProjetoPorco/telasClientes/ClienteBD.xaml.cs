using System;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class ClienteBD : ContentPage
    {
        public ClienteBD()
        {
            InitializeComponent();
        }

        	private void Voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }

            private void add(object sender, EventArgs args)
	{
		Application.Current.MainPage = new ClienteCadastro();
    }
    }
}