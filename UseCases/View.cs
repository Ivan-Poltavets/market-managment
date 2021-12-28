using Core;
using UseCases.DataStore;

namespace UseCases
{
    public class View : IView
    {
        private readonly ICategoryRepository categoryRepository;
        public View(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}