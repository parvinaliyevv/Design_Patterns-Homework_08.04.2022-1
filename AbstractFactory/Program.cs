using System;

namespace AbstractFactory
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var app = new Application(new Concrete.MacFactory());

            app.CreateButton();
            app.CreateChecbox();

            app.PaintButton(ConsoleColor.Green);
            app.PaintCheckbox(ConsoleColor.Yellow);
        }
    }
}
