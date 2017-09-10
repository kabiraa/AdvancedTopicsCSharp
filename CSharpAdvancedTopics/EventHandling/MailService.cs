using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.EventHandling
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEncoderEventArgs args) {
            Console.WriteLine("Sending mail... " + args.Video.Title);
        }
    }
}
