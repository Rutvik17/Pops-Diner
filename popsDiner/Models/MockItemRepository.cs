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
                    new Item {ItemId = 1, Name="Big Mac Burger", Price=5.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://checkers.com/wp-content/uploads/2017/03/Spicy-Chicken-Sandwich-V1.jpg", InStock=true, isItemOfTheWeek=true, ImageThumbnailUrl="https://checkers.com/wp-content/uploads/2017/03/Spicy-Chicken-Sandwich-V1.jpg"},
                    new Item {ItemId = 2, Name="Tripple Thick", Price=9.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[1],ImageUrl="https://sjmagazine.net/wp-content/uploads/cache/2017/01/milkshake/2259248381.jpg", InStock=true, isItemOfTheWeek=false, ImageThumbnailUrl="https://sjmagazine.net/wp-content/uploads/cache/2017/01/milkshake/2259248381.jpg"},
                    new Item {ItemId = 3, Name="Burger Combo", Price=10.95M, shortDescription="", LongDescription="", Category = _categoryRepository.Categories.ToList()[2],ImageUrl="https://media.socialdeal.nl/deal/horeca-t-kwadraat-15081212565167.jpg", InStock=true, isItemOfTheWeek=false, ImageThumbnailUrl="https://media.socialdeal.nl/deal/horeca-t-kwadraat-15081212565167.jpg"},
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
