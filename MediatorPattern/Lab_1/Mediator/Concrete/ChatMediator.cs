using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_1.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> _users;

        public ChatMediator()
        {
            _users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
           _users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
