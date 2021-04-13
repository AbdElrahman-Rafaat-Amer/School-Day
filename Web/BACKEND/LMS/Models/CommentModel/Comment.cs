using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.CommentModel
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime Date { get; set; }
        public string Photo { get; set; }
        public PostModel.Post Post { get; set; }
        public AccountModel.Account Account { get; set; }

    }
}
