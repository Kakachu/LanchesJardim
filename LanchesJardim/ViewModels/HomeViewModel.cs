using LanchesJardim.Models;
using System.Collections.Generic;

namespace LanchesJardim.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
