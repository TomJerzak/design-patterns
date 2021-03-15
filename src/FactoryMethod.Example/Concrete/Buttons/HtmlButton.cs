using System;
using FactoryMethod.Example.Abstract;

namespace FactoryMethod.Example.Concrete.Buttons
{
    internal class HtmlButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("[HtmlButton]->Render");
        }

        public void OnClick()
        {
            Console.WriteLine("[HtmlButton]->OnClick");
        }
    }
}