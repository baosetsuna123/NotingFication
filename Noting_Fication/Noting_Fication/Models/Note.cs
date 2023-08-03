using System;
using System.Collections.Generic;

#nullable disable

namespace Noting_Fication.Models
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int? CategoryId { get; set; }
        public bool? Status { get; set; }
        public DateTime? Deadline { get; set; }
        public string Content { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
