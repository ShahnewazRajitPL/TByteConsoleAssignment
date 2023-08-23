using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Composite
{
    public static class ClientForComposite
    {
        public static void UseComposite()
        {
            //leaf objects
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 1000);
            IComponent cpu = new Leaf("CPU", 2500);
            IComponent mouse = new Leaf("Mouse", 500);
            IComponent keyBoard = new Leaf("KeyBoard", 1000);

            //composite objects
            Composite motherBoard = new Composite("Mother Board");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Perpherals");
            Composite computer = new Composite("Computer");

            motherBoard.AddComponent(ram);
            motherBoard.AddComponent(cpu);

            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyBoard);

            computer.AddComponent(peripherals);
            computer.AddComponent(cabinet);

            Console.WriteLine("\nPrice of cabinet:");
            cabinet.DisplayPrice();
        }
    }
}
