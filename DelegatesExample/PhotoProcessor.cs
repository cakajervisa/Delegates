using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
  
    public class PhotoProcessor
    {

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);

        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);

        //    photo.Save();
        //}
        //public delegate void PhotoFilterHandler(Photo photo);

        //public void Process(string path, PhotoFilterHandler filterHandler)
        //{
        //    var photo = Photo.Load(path);

        //    filterHandler(photo);

        //    photo.Save();
        //}


    }
}
