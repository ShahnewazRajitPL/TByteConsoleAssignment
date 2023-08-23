using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.Mediator
{
    public class ConcreteFacebookGroupMediator : IFacebookMediator
    {
        private List<User> userList = new List<User>();
        public void RegisterUser(User user)
        {
            userList.Add(user);
            user.Mediator = this;
        }

        public void SendMessage(string msg, User us)
        {
            foreach (User user in userList)
            {
                if(user != us)
                {
                    user.Receive(msg);
                }
            }
        }
    }
}
