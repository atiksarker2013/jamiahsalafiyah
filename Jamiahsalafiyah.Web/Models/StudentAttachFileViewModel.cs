using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public class StudentAttachFileViewModel
    {
        public int Id { get; set; }
        public Nullable<int> Student_FK { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

    }
}