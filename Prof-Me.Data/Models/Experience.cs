using System;

namespace Prof_Me.Data.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string PostType { get; set; }
        public DateTime Join { get; set; }
        public DateTime Leave { get; set; }
        public string Description { get; set; }
        public UserProfile User { get; set; }



    }
}
