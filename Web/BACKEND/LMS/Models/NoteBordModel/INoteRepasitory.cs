using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.NoteBordModel
{
  public interface INoteRepasitory<T>
    {
        void CreateNote(T note);
        void UpdateNote(T note);
        void DeleteNote(int Id);
        Task<NoteBoard> Note(int Id);
        List<NoteBoard> Note();
    }
}
