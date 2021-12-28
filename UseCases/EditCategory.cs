using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStore;

namespace UseCases
{
    public class EditCategory : IEditCategory
    {
        private readonly ICategoryRepository categoryRepository;

        public EditCategory(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Execute(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }
    }
}
