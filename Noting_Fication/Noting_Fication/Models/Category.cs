using System;
using System.Collections.Generic;

#nullable disable

namespace Noting_Fication.Models
{
    public partial class Category
    {
        public Category()
        {
            Notes = new HashSet<Note>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
