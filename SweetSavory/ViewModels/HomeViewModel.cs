using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace SweetSavory.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flavor> Flavors { get; set; }
        public IEnumerable<Treat> Treats { get; set; }
    }
}