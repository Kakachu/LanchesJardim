using LanchesJardim.Models;
using System.Collections.Generic;

namespace LanchesJardim.Repositories
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
