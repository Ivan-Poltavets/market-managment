using Core;

namespace UseCases
{
    public interface IViewCategoryUseCase
    {
        IEnumerable<Category> Execute();
    }
}