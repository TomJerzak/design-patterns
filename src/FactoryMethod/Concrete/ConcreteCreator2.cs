using FactoryMethod.Abstract;
using FactoryMethod.Concrete.Products;

namespace FactoryMethod.Concrete
{
    internal class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}