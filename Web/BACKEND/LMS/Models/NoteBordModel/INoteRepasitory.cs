using LMS.Models.AccountModel;
using LMS.ViewModels.NoteBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.NoteBordModel
{
  public interface INoteRepasitory<T>
    {
        void CreateNote(NoteCreateRequest note);
        void UpdateNote(T note);
        void DeleteNote(int Id,Account account);
        Task<NoteBoard> Note(int Id);
        NoteSubject GetSubject(int id);
        List<ShowNoteBoardVM> Notes(Func<T, bool> lamda);
        List<NoteBoard> NotesByFiltter(Func<T, bool> lamda);
        List<NoteSubject> SubjectInNote();
    }
}
