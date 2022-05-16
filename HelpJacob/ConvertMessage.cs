namespace HelpJacob
{
    // This class converts a message body to html
    public class ConvertMessage
    {
        public void ConvertMessageToHTML(Message m)
        {
            m.Body = ConvertBodyToHTML(m.Body);
        }

        private string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
