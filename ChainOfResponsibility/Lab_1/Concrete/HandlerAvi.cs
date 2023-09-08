using ChainOfResponsibility.Lab_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Lab_1.Concrete
{
    public class HandlerAvi:PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".avi"))
                Console.WriteLine($"{fileType} tipinde medya oynatılıyor..!");
            else Console.WriteLine("Geçersiz medya tipi...!");
        }
    }
}
