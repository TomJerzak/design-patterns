using System;
using FactoryMethod.Example.Concrete;

namespace FactoryMethod.Example
{
    internal class Application
    {
        private Dialog _dialog;

        public void Main()
        {
            Initialize();
            _dialog.Render();
        }

        private void Initialize()
        {
            var platform = "Windows";
            // var platform = "Web";

            _dialog = platform switch
            {
                "Windows" => new WindowsDialog(),
                "Web" => new WebDialog(),
                _ => throw new Exception("Unknown platform.")
            };
        }
    }
}