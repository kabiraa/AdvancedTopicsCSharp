using System;
using System.Threading;

namespace CSharpAdvancedTopics.EventHandling
{
    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Define an event based on delegate
        //3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void EncodeVideo(Video video) {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);

            OnVideoEncoded();
        }

        //Event Publisher methods should be protected, virtual and void
        protected virtual void OnVideoEncoded() {
            if (VideoEncoded != null) //need to check if event has any subscriptions yet.
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
