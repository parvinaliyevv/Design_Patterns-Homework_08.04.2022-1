using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class UIElement : IRender
    {
        public ConsoleColor Color { get; set; }

        public abstract void Render();
    }
}
