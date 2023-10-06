using System;

namespace Patterns2
{
    interface IVideoProcessing
    {
        void VideoProcessing();
    }
    class Video : IVideoProcessing
    {
        public void VideoProcessing()
        {
            Console.WriteLine("Processing video");
        }
    }
    class SlowMotionDecorator : IVideoProcessing
    {
        private IVideoProcessing thisVideoProcessing;

        public SlowMotionDecorator(IVideoProcessing videoProcessing)
        {
            thisVideoProcessing = videoProcessing;
        }

        public void VideoProcessing()
        {
            thisVideoProcessing.VideoProcessing();
            Console.WriteLine("slow motion putting");
        }
    }
    class SpeedUpDecorator : IVideoProcessing
    {
        private IVideoProcessing thisVideoProcessing;

        public SpeedUpDecorator(IVideoProcessing videoProcessing)
        {
            thisVideoProcessing = videoProcessing;
        }

        public void VideoProcessing()
        {
            thisVideoProcessing.VideoProcessing();
            Console.WriteLine("speeding up video");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IVideoProcessing video = new Video();
            video.VideoProcessing();

            IVideoProcessing slowMotionVideo = new SlowMotionDecorator(video);
            slowMotionVideo.VideoProcessing();

            IVideoProcessing speedUpVideo = new SpeedUpDecorator(video);
            speedUpVideo.VideoProcessing();
        }
    }
}
