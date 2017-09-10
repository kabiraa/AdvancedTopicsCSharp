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
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //subscriber subscribing to event
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //subscriber subscribing to eventA
			videoEncoder.EncodeVideo(video); // publisher publishing the event

            Console.Read();
        }
    }
}
