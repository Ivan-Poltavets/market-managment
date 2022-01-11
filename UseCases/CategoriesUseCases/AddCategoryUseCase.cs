using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStore;

namespace UseCases
{
    public class AddCategoryUseCase : IAddCategory
    {
        private readonly ICategoryRepository categoryRepository;
        public AddCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.AddCategory(category);
        }
    }
}
