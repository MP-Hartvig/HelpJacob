using HelpJacob.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string to = "Til@Test.com";
            string from = "Fra@Test.com";
            string body = "This is the body";
            string subject = "Test";
            string cc = "";

            bool isHTML = true;

            Message message = new Message(to, from, body, subject, cc);

            //// These have no use
            //MessageCarrier smtp = MessageCarrier.Smtp;
            //MessageCarrier vMessage = MessageCarrier.VMessage;

            message.ConvertMessageToHTML(message, isHTML);

            message.SendSMTP(message);
            message.SendVMessage(message);
        }
    }
}
