/* Factory Method Design Pattern
 *
 * Intent: Provides an interface for creating objects in a superclass, but
 * allows subclasses to alter the type of objects that will be created.
 */
namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
