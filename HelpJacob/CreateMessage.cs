using System.Collections.Generic;

namespace HelpJacob
{
    // This class creates an email message
    public class CreateMessage
    {
        string to, from, body, subject;
        List<string> cc;

        public CreateMessage(string to, string from, string body, string subject, List<string> cc)
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
        public List<string> Cc { get => cc; set => cc = value; }
    }
}
