using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PedidosBD
{
    public partial class PedidosPage : ContentPage
    {
        public ObservableCollection<Pedido> Pedidos { get; set; }

        public ICommand MoreOptionsCommand { get; private set; }

        public PedidosPage()
        {
            //InitializeComponent();

            Pedidos = new ObservableCollection<Pedido>
            {
                new Pedido { Nome = "pedido 1" },
                new Pedido { Nome = "pedido 2" },
                new Pedido { Nome = "pedido 3" },
                new Pedido { Nome = "pedido 4" },
                new Pedido { Nome = "pedido 5" },
                new Pedido { Nome = "pedido 6" },
                new Pedido { Nome = "pedido 7" }
            };

            MoreOptionsCommand = new Command<Pedido>(OnMoreOptionsClicked);

            BindingContext = this;
        }

        private void OnMoreOptionsClicked(Pedido pedido)
        {
            // Lógica para as opções adicionais do pedido
            DisplayAlert("Opções", $"Opções para {pedido.Nome}", "OK");
        }

        private void OnAddPedidoClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo pedido
            DisplayAlert("Adicionar Pedido", "Novo pedido adicionado", "OK");
        }
    }

    public class Pedido
    {
        public string Nome { get; set; }
    }
}