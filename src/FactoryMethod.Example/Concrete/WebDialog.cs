using FactoryMethod.Example.Abstract;
using FactoryMethod.Example.Concrete.Buttons;

namespace FactoryMethod.Example.Concrete
{
    internal class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
