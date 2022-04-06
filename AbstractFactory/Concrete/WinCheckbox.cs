using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class WinCheckbox : Checkbox
    {
        public override void Select() => Console.WriteLine("Selected Windows Checkbox");

        public override void UnSelect() => Console.WriteLine("UnSelected Windows Checkbox");

        public override void Render() => Console.WriteLine("Rendered Windows Checkbox");
    }
}
