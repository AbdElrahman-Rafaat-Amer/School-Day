using LMS.Controllers;
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
        public void CreateNote(NoteBoard note)
        {
            
            context.Add(note);
            context.SaveChanges();
        }

        public void DeleteNote(int Id)
        {
            var noteid=context.NoteBoards.Find(Id);
            context.Remove(noteid);
            context.SaveChanges();
        }

        public async Task<NoteBoard> Note(int Id)
        {
            return await context.NoteBoards.FindAsync(Id);
        }

        public List<NoteBoard> Notes()
        {
            var l = context.NoteBoards.ToList();
            return l;
        }

        public List<NoteBoard> NotesByFiltter(Func<NoteBoard, bool> lamda)
        {
            var l = context.NoteBoards.Where(lamda).ToList();
            return l;
        }

        public void UpdateNote(NoteBoard note)
        {
            context.NoteBoards.Update(note);
            context.SaveChanges();
        }
    }
}
