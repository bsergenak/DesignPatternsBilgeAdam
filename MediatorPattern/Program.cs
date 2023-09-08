using MediatorPattern.Lab_1.Concrete;
using MediatorPattern.Lab_1.Interface;
using MediatorPattern.Lab_1.Mediator.Concrete;
using MediatorPattern.Lab_1.Mediator.Interface;
using MediatorPattern.Lab_2.Concrete;
using MediatorPattern.Lab_2.Mediator;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab 1
            //IChatMediator chatMediator = new ChatMediator();

            //IUser arda = new BasicUser("beast", chatMediator);
            //IUser naz = new GoldUser("kaptan", chatMediator);
            //IUser kutay = new BasicUser("kutai", chatMediator);

            //chatMediator.AddUser(arda);
            //chatMediator.AddUser(naz);
            ////chatMediator.AddUser(kutay);

            //arda.SendMessage("Suprize..!");

            #endregion

            #region Lab 2
            CoreMediator coreMediator = new CoreMediator();

            Teacher teacher = new Teacher(coreMediator);
            teacher.Name = "Barkın";

            Student arda = new Student(coreMediator);
            arda.Name = "Arda";

            Student sergen = new Student(coreMediator);
            sergen.Name = "Sergen";

            coreMediator.Students = new List<Student> { arda, sergen };
            coreMediator.Teacher = teacher;

            arda.SendQuestion("3 tavşan 3 havucu 3 dakikada yerse, bir tavşan 1 havucu kaç dakika da yer?");

            teacher.AnswerQuestion("Çok zor soru bilmiyorum...!", arda);

            teacher.ReceiveQuestion("pşşştt hoca...!", sergen);
            teacher.AnswerQuestion("Hoop...! Köylüüm..!", sergen);

            coreMediator.MediatorSendQuestion("soru", sergen);
            coreMediator.MediatorSendAnswer("cevap", sergen);


            #endregion
            Console.ReadKey();
        }
    }
}
