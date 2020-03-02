using System;
using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [Display(Name = "Company Name")]
        public string Company { get; set; }
        [Display(Name = "Job Post")]
        public string PostType { get; set; }
        [Display(Name = "Joined Date")]
        public DateTime Join { get; set; }
        [Display(Name = "Leave Date")]
        public DateTime Leave { get; set; }
        public string Description { get; set; }
        public UserProfile User { get; set; }



    }
}
