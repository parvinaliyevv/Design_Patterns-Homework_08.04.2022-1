using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Application
    {
        private IGUIFactory _factory;

        private Button _button;
        private Checkbox _checkbox;


        public Application(IGUIFactory factory)
            =>_factory = factory ?? throw new ArgumentNullException(nameof(factory));


        public void CreateButton()
        {
            _button = _factory.CreateButton();
            Console.WriteLine("Button created and assign!");
        }
        public void CreateChecbox()
        {
            _checkbox = _factory.CreateCheckbox();
            Console.WriteLine("Checkbox created and assign!");
        }

        public void PaintButton(ConsoleColor color)
        {
            _button.Color = color;
            Console.WriteLine("Button painted!");
        }
        public void PaintCheckbox(ConsoleColor color)
        {
            _checkbox.Color = color;
            Console.WriteLine("Checkbox painted!");
        }
    }
}
