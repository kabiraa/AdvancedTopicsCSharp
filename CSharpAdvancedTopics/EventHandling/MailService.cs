using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.EventHandling
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args) {
            Console.WriteLine("Sending mail...");
        }
    }
}
