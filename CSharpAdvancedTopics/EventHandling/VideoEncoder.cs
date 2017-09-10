using System;
using System.Threading;

namespace CSharpAdvancedTopics.EventHandling
{
    public class VideoEncoderEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Define an event based on delegate
        //3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, VideoEncoderEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void EncodeVideo(Video video) {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(5000);

            OnVideoEncoded(video);
        }

        //Event Publisher methods should be protected, virtual and void
        protected virtual void OnVideoEncoded(Video video) {
            if (VideoEncoded != null) //need to check if event has any subscriptions yet.
                VideoEncoded(this, new VideoEncoderEventArgs(){Video = video});
        }
    }
}
