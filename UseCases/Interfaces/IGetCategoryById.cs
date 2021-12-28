using Core;

namespace UseCases
{
    public interface IGetCategoryById
    {
        Category Execute(int categoryId);
    }
}