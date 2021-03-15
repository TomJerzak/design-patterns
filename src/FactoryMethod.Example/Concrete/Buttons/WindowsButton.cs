using System;
using FactoryMethod.Example.Abstract;

namespace FactoryMethod.Example.Concrete.Buttons
{
    internal class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("[WindowsButton]->Render");
        }

        public void OnClick()
        {
            Console.WriteLine("[WindowsButton]->OnClick");
        }
    }
}