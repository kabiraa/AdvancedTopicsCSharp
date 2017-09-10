using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterProcess(Photo photo);

        public void Process(string path, Action<Photo> filterHandler) {
            var photo = Photo.Load(path);
            //Action<> - Delegate that can take upto 16 parameters. It returns void.
            //Func<> - Delegate that can also take 16 parameters but it returns a value.
            filterHandler(photo);
        }
    }
}
