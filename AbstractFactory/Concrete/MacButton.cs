using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class MacButton: Button
    {
        public override void Click() => Console.WriteLine("Clicked Mac Button");

        public override void DoubleClick() => Console.WriteLine("Double Clicked Mac Button");

        public override void Render() => Console.WriteLine("Rendered Mac Button");
    }
}
