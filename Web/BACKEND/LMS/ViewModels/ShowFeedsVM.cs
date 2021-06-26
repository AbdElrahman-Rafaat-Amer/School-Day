using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.ViewModels
{
    public class ShowFeedsVM
    {
        public int Id { get;    set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public List<string> Photos { get; set; }
        public int AccountId { get; set; }
        public int Like { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
    }
}
