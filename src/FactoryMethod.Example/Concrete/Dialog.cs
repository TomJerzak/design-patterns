using System;
using FactoryMethod.Example.Abstract;

namespace FactoryMethod.Example.Concrete
{
    internal abstract class Dialog
    {
        public abstract IButton CreateButton();

        public void Render()
        {
            var button = CreateButton();
            button.OnClick();
            button.Render();

            Console.WriteLine("[Dialog]->Render");
        }
    }
}