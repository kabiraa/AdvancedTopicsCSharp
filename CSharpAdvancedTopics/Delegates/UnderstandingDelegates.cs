using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.Delegates
{
    public class UnderstandingDelegates
    {
        public UnderstandingDelegates()
        {
            var photoProcessor = new PhotoProcessor();

            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RedEyeFilter;

            photoProcessor.Process("A Photo", filterHandler);

            Console.ReadLine();
        }

        static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RedEyeFilter");
        }
    }
}
