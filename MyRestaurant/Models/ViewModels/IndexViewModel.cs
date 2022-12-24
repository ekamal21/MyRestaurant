using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRestaurant.Models.ViewModels
{
    public class IndexViewModel
    {
        //this modle to display category and menuItem
        public IEnumerable<MenuItem> MenuItem { get; set; }
        public IEnumerable<Category> Category { get; set; }
      

    }
}
