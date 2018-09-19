using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using popsDiner.Models;

namespace popsDiner.ViewsModel
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}
