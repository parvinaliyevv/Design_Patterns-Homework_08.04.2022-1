using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class MacFactory : IGUIFactory
    {
        public Button CreateButton() => new MacButton();

        public Checkbox CreateCheckbox() => new MacCheckbox();
    }
}
