using Core;
using UseCases.DataStore;

namespace UseCases
{
    public class ViewCategoryUseCase : IViewCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public ViewCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
        {
            return categoryRepository.GetCategories();
        }
    }
}