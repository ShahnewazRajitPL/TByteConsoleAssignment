using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.Mediator
{
    public abstract class User
    {
        protected string Name;
        //property Mediator Instance

        public IFacebookMediator Mediator { get; set; }

        protected User(string name)
        {
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
