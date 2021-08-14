using System.Collections.Generic;

namespace SweetSavory.Models.ViewModels
{
    public class HomeViewModels
    {
        public IEnumerable<Flavor> Flavors { get; set; }
        public IEnumerable<Treat> Treats { get; set; }
    }
}