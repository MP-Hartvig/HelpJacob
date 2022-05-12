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
            List<string> cc = new List<string>();
            string to = "Til@Test.com";
            string from = "Fra@Test.com";
            string body = "This is the body";
            string subject = "Test";
            cc.Add("");

            CreateMessage message = new CreateMessage(to, from, body, subject, cc);

            bool isHTML = true;
            ConvertMessage convert = new ConvertMessage();
            convert.ConvertMessageToHTML(message, isHTML);

            SendSMTP sendSMTP = new SendSMTP();
            sendSMTP.SendSingleSMTP(message);
            sendSMTP.SendMultipleSMTP(cc, message);

            SendVMessage sendVMessage = new SendVMessage();
            sendVMessage.SendSingleVMessage(message);
            sendVMessage.SendMultipleVMessage(cc, message);
        }
    }
}
