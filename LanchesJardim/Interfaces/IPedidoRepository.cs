using LanchesJardim.Models;

namespace LanchesJardim.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
