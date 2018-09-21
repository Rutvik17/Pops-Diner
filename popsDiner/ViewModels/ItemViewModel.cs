using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popsDiner.ViewModels
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
