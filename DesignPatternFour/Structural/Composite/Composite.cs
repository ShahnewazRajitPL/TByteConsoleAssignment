using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Composite
{
    public class Composite : IComponent
    {
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void DisplayPrice()
        {
            foreach(IComponent item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
