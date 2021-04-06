using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.TaskModel
{
   public interface ITaskRepasitory<T>
    {
        void CreateTask(T task);
        void UpdateTask(T task);
        void DeleteSubject(int Id);
        Task<Task> Task(int Id);
        List<Task> Tasks();
    }
}
