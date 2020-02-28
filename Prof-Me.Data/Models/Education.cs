using System;

namespace Prof_Me.Data.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string EName { get; set; }
        public DateTime Join { get; set; }
        public DateTime Leave { get; set; }
        public UserProfile User { get; set; }

    }
}
