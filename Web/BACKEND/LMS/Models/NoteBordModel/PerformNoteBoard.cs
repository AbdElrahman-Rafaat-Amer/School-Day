using LMS.Controllers;
using LMS.Models.AccountModel;
using LMS.Models.SubjectModel;
using LMS.ViewModels.NoteBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.NoteBordModel
{
    public class PerformNoteBoard :  INoteRepasitory<NoteBoard>
    {
        private readonly AppDbContext context;

        public PerformNoteBoard(AppDbContext context)
        {
            this.context = context;
        }

        public void CreateNote(NoteCreateRequest note)
        {
            int sid = int.Parse(note.Subjectid);
            var subject = context.Subjects.FirstOrDefault(s => s.Id == sid);
            //var task = context.Tasks.FirstOrDefault(t => t.Id == tid);
            NoteBoard Note = new NoteBoard()
            {
                Title = note.Title,
                Text = note.Text,
                Account = note.Account,
                Subject = subject,
                //Task = task,
                Date = DateTime.Now
            };
            context.NoteBoards.Add(Note);
            context.SaveChanges();
        }

        public void DeleteNote(int Id,Account account)
        {
            var note = context.NoteBoards.Find(Id);
            if (note.Account == account)
            {
                context.NoteBoards.Remove(note);
                context.SaveChanges();
            }
        }

        public async Task<NoteBoard> Note(int Id)
        {
            return await context.NoteBoards.FindAsync(Id);
        }

        public List<ShowNoteBoardVM> Notes(Func<NoteBoard, bool> lamda)
        {
            var Notes = context.NoteBoards.Where(lamda).ToList();
            List<ShowNoteBoardVM> ShowNoteBoard = new List<ShowNoteBoardVM>();
            foreach(var Note in Notes)
            {
                ShowNoteBoard.Add(new ShowNoteBoardVM
                {
                    Id = Note.Id,
                    Text = Note.Text,
                    Title = Note.Title,
                    Date = Note.Date,
                    //Photo = Note.Subject.Photo,
                    //Color = Note.Subject.Color,
                    //Subjectid = Note.Subject.Id,
                    //Taskid = Note.Task.Id
                }
                );
            }
            return ShowNoteBoard;
        }

        public List<NoteBoard> NotesByFiltter(Func<NoteBoard, bool> lamda)
        {
            return context.NoteBoards.Where(lamda).ToList();
        }

        public void UpdateNote(NoteBoard note)
        {
            context.NoteBoards.Update(note);
            context.SaveChanges();
        }

        public List<NoteSubject> SubjectInNote()
        {
            var subjects = context.Subjects.ToList();
            List<NoteSubject> noteSubjects = new List<NoteSubject>();
            foreach (var subject in subjects)
            {
                noteSubjects.Add(new NoteSubject()
                {
                    Id = subject.Id,
                    Name = subject.Name
                });
            }
            return noteSubjects;
        }

        public NoteSubject GetSubject(int id)
        {
            var subject = context.Subjects.Find(id);
            return new NoteSubject() { Id = subject.Id, Name = subject.Name };
        }
    }
}
