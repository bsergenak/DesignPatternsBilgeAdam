using MediatorPattern.Lab_2.Abstract;
using MediatorPattern.Lab_2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_2.Concrete
{
    public class Student : AssignedCourseMember
    {
        //Student sınıfını initialize ederken şiçerisine CoreMediator tipinde bir parametre alacak. Aldığı bu parametreyi sınıf içeriisnde kullanmadığımızdan private bir üyeye atamadık. Sadece gelen parametreyi ata sınıfına göndermek için ctor kullandık.
        public Student(CoreMediator coreMediator) : base(coreMediator){}
        public string Name { get; set; }

        public void SendQuestion(string question) => Console.WriteLine($"{this.Name}: {question}");

        public void ReceiveAnswer(string answer) => Console.WriteLine($"Student received answer {answer}");


    }
}
