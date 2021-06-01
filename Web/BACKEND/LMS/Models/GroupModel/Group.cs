using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.GroupModel
{
    public class Group
    {
        public Group()
        {
            this.members =new HashSet<AccountModel.Account>();
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PostModel.Post> posts { get; set; }
        public ICollection<AccountModel.Account> members { get; set; }
    }
}
