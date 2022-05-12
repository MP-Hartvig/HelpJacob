using System.Collections.Generic;

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
            cc.Add("CC1@Test.com");

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
