using System;
namespace CSharpAdvancedTopics.EventHandling
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEncoderEventArgs args){
            Console.WriteLine("Sending a text message... " + args.Video.Title);
        }
    }
}
