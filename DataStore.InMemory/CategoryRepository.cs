using Core;
using UseCases.DataStore;

namespace DataStore.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
                new Category { CategoryId = 2, Name = "Backery", Description = "Backery" }
            };
        }
        public void AddCategory(Category category)
        {
            if(categories.Any(x=>x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            categories.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            var categoryUpdate = GetCategoryById(category.CategoryId);
            if(categoryUpdate != null)
            {
                categoryUpdate.Name = category.Name;
                categoryUpdate.Description = category.Description;
            }
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
        }
    }
}