using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class Checkbox : UIElement, ICheckbox
    {
        public abstract void Select();

        public abstract void UnSelect();

        public abstract override void Render();
    }
}
