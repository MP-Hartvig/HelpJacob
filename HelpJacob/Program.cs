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

            MessageCarrier smtp = MessageCarrier.Smtp;
            MessageCarrier vMessage = MessageCarrier.VMessage;

            Message message = new Message(to, from, body, subject, cc);

            message.ConvertMessageToHTML(message, isHTML);

            message.SendSMTP(smtp, message);
            message.SendVMessage(vMessage, message);
        }
    }
}
