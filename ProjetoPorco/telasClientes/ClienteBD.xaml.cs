using System;
using Microsoft.Maui.Controls;

namespace ProjetoPorco
{
    public partial class ClienteBD : ContentPage
    {
        Controles.ClienteControle clienteControle = new Controles.ClienteControle(); 
        public ClienteBD()
        {
            InitializeComponent();
        ListaClientes.ItemsSource = clienteControle.LerTodos();
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