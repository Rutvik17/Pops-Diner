using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popsDiner.Models
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {ItemId = 1, Name="Big Mac Burger", Price=5.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, isItemOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                    new Item {ItemId = 2, Name="Tripple Thick", Price=3.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, isItemOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                    new Item {ItemId = 3, Name="Burger Combo", Price=10.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, isItemOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                };
            }
        }

        public IEnumerable<Item> ItemsOfTheWeek { get; }
        public Item GetItemById(int itemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
