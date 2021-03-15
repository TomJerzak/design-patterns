using FactoryMethod.Example.Abstract;
using FactoryMethod.Example.Concrete.Buttons;

namespace FactoryMethod.Example.Concrete
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
