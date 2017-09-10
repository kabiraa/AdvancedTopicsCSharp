using System;

namespace CSharpAdvancedTopics.EventHandling
{
    public class UnderstandingEventHandling
    {
        public UnderstandingEventHandling()
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //subscriber subscribing to event
            videoEncoder.EncodeVideo(video); // publisher publishing the event

            Console.Read();
        }
    }
}
