using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Products
{
    /// <summary>
    /// Concrete Products provide various implementations of the Product
    /// interface.
    /// </summary>
    internal class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}