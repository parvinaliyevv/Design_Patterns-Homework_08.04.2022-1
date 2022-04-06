using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class Button : UIElement, IButton
    {
        public abstract void Click();

        public abstract void DoubleClick();

        public abstract override void Render();
    }
}
