using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popsDiner.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId=1, CategoryName="Burgers", Description="",},
                    new Category {CategoryId=2, CategoryName="Drinks", Description=""},
                    new Category {CategoryId=3, CategoryName="Combos", Description=""}
                };
            }
        }
    }
}
