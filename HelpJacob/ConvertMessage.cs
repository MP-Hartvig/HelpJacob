using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    // This class converts a message body to html
    public class ConvertMessage
    {
        public void ConvertMessageToHTML(CreateMessage m, bool isHTML)
        {
            if (isHTML)
                m.Body = ConvertBodyToHTML(m.Body);
        }

        private string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
    }
}
