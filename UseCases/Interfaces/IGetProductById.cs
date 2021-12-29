using Core;

namespace UseCases
{
    public interface IGetProductById
    {
        Product Execute(int productId);
    }
}