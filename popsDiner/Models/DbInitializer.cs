using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popsDiner.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
           
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Items.Any())
            {
                context.AddRange
                (
                    new Item { Name = "Luger Burger", Price = 12.95M, shortDescription = "Our famous burger!", LongDescription = "Lorem Ipsum", Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Vanilla", Price = 18.95M, shortDescription = "You'll love it!", LongDescription = "Lorem Ipsum", Category = Categories["Drinks"], ImageUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://www.cookswithcocktails.com/wp-content/uploads/Coffee-1.jpg", AllergyInformation = "" },
                    new Item { Name = "Chocolate", Price = 18.95M, shortDescription = "You'll love it!", LongDescription = "Lorem Ipsum", Category = Categories["Drinks"], ImageUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://media.self.com/photos/58988ad2fc1087d526ccb7be/4:3/w_728,c_limit/starbucks-thumb.jpg", AllergyInformation = "" },
                    new Item { Name = "Burger + Fries", Price = 15.95M, shortDescription = "Our Halloween Favorite!", LongDescription = "Lorem Ipsum", Category = Categories["Combos"], ImageUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://i.dailymail.co.uk/i/pix/2017/11/08/16/4623608900000578-0-image-a-9_1510156892900.jpg", AllergyInformation = "" },
                    new Item { Name = "Le Pigeon Burger", Price = 13.95M, shortDescription = "Our famous burger!", LongDescription = "Lorem Ipsum", Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Double Animal Style", Price = 17.95M, shortDescription = "Our famous burger!", LongDescription = "Lorem Ipsum", Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "The Original Burger", Price = 15.95M, shortDescription = "Our famous burger!", LongDescription = "Lorem Ipsum", Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" },
                    new Item { Name = "Mango", Price = 12.95M, shortDescription = "You'll love it!", LongDescription = "Lorem Ipsum", Category = Categories["Drinks"], ImageUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "http://www.bombaytasty.com/wp-content/uploads/2014/10/Mango-Lassi.jpg", AllergyInformation = "" },
                    new Item { Name = "Burger + Fries + Drink", Price = 15.95M, shortDescription = "Our Halloween Favorite!", LongDescription = "Lorem Ipsum", Category = Categories["Combos"], ImageUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg", InStock = true, isItemOfTheWeek = true, ImageThumbnailUrl = "http://image.posta.com.mx/sites/default/files/9616591eff8c54c0778c907617c14488.jpg", AllergyInformation = "" },
                    new Item { Name = "Pomegranate", Price = 15.95M, shortDescription = "You'll love it!", LongDescription = "Lorem Ipsum", Category = Categories["Drinks"], ImageUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg", InStock = true, isItemOfTheWeek = false, ImageThumbnailUrl = "https://www.vibrantplate.com/wp-content/uploads/2018/01/Pommegranate-juice-06.jpg", AllergyInformation = "" },
                    new Item { Name = "Big Mac", Price = 18.95M, shortDescription = "Our famous burger!", LongDescription = "Lorem Ipsum", Category = Categories["Burgers"], ImageUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", InStock = false, isItemOfTheWeek = false, ImageThumbnailUrl = "https://foodal.com/wp-content/uploads/2015/07/5-Tasty-Ideas-to-Liven-Up-Your-Burgers.jpg", AllergyInformation = "" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Burgers" },
                        new Category { CategoryName = "Combos" },
                        new Category { CategoryName = "Drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
