using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(string name): base(name)
        {

        }
        public override void Receive(string message)
        {
            Console.WriteLine(this.Name + ": Received Message:" + message);

        }

        public override void Send(string message)
        {
            Console.WriteLine(this.Name + ": Sending Message =" + message + "\n");
            Mediator.SendMessage(message, this);

        }
    }
}
