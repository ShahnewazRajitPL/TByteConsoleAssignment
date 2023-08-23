using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.Mediator
{
    public  interface IFacebookMediator
    {
        void SendMessage(string msg, User user);

        void RegisterUser(User user);
    }
}
