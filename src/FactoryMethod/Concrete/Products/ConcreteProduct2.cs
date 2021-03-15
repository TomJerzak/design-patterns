using FactoryMethod.Abstract;

namespace FactoryMethod.Concrete.Products
{
    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}