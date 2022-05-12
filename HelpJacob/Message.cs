using HelpJacob.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    public class Message
    {
        string to, from, body, subject, cc;

        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }

        public void ConvertMessageToHTML(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
        }

        public string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }

        public void SendSMTP(MessageCarrier smtp, Message m)
        {
            //her implementeres alt koden til at sende via Smtp
        }

        public void SendVMessage(MessageCarrier vMessage, Message m)
        {
            //her implementeres alt koden til at sende via VMessage
        }
    }
}
