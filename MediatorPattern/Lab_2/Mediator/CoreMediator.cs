using MediatorPattern.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab_2.Mediator
{
    public class CoreMediator
    {
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }

        public void MediatorSendQuestion(string question, Student student) => Teacher.ReceiveQuestion(question, student);

        public void MediatorSendAnswer(string answer, Student student) => student.ReceiveAnswer(answer);
    }
}
