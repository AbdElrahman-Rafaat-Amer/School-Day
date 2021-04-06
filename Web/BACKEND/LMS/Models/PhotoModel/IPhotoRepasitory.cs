using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.PhotoModel
{
   public interface IPhotoRepasitory<T>
    {
        void CreatePhoto(T photo);
        void UpdatePhoto(T photo);
        void DeletePhoto(int Id);
        Task<Photo> Photo(int Id);
        List<Photo> Photos();
    }
}
