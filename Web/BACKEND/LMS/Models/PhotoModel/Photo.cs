using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Models.PhotoModel
{
    public class Photo
    {
        public int Id { get; set; }
        public string _Photo { get; set; }
        public PostModel.Post Post { get; set; }

    }
}
