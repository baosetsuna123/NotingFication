using System;
using System.Collections.Generic;

#nullable disable

namespace Noting_Fication.Models
{
    public partial class User
    {
        public User()
        {
            Notes = new HashSet<Note>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
