using LanchesJardim.Models;
using System.Collections.Generic;

namespace LanchesJardim.ViewModels
{
    public class PedidoLancheViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoDetalhe> PedidoDetalhes{ get; set; }
    }
}
