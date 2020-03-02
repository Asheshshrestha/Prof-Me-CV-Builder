using System;
using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class Education
    {
        public int Id { get; set; }
        [Display(Name = "Education Level")]
        public string Level { get; set; }
        [Display(Name = "Institute Name")]
        public string EName { get; set; }
        [Display(Name = "Joined Date")]
        public DateTime Join { get; set; }
        [Display(Name = "Leave Date")]
        public DateTime Leave { get; set; }
        public UserProfile User { get; set; }

    }
}
