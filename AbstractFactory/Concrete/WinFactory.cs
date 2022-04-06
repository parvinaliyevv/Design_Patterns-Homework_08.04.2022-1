using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class WinFactory : IGUIFactory
    {
        public Button CreateButton() => new WinButton();

        public Checkbox CreateCheckbox() => new WinCheckbox();
    }
}
