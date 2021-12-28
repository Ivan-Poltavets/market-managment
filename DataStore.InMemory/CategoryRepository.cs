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
                new Category { CategoryId = 1, Name = "Fruits", Description = "Fruits" },
                new Category { CategoryId = 2, Name = "Vegetables", Description = "Vegetables" }
            };
        }
        public void AddCategory(Category category)
        {
            if(categories.Any(x=>x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))return;
            if (categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
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
        public void DeleteCategory(int categoryId)
        {
            categories?.Remove(GetCategoryById(categoryId));
        }
    }
}