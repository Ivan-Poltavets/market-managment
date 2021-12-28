using Core;

namespace UseCases
{
    public interface IView
    {
        IEnumerable<Category> Execute();
    }
}