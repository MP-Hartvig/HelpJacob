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

            Message message = new Message(to, from, body, subject, cc);

            ConvertMessage convert = new ConvertMessage();
            convert.ConvertMessageToHTML(message);

            SendSMTP sendSMTP = new SendSMTP();
            sendSMTP.SendSMTPMessages(message);

            SendVMessage sendVMessage = new SendVMessage();
            sendVMessage.SendVMessages(message);
        }
    }
}
