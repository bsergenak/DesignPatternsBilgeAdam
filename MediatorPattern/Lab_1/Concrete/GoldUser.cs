using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_1.Concrete
{
    public class GoldUser : IUser
    {
        string _userName;
        IChatMediator _chatMediator;

        public GoldUser(string userName, IChatMediator chatMediator)
        {
            _userName = userName;
            _chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı Tipi: Gold\nKullanıcı Adı: {_userName}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
