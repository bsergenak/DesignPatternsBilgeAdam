using DecarotorPattern.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecarotorPattern.Lab_1.Clients
{
    public class Client
    {
        public static void Display(string s, IBilesen bilesen) => Console.WriteLine(s + bilesen.Operation());
    }
}
