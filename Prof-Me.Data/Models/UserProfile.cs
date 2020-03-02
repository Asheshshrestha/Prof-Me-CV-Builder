using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public string Address { get; set; }
        [Display(Name = "Cover Image")]
        public string CoverImage { get; set; }
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }
        public string Universiy { get; set; }
        public string Company { get; set; }
        public string Post { get; set; }

        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Skills> Skills { get; set; }
        public IEnumerable<Accomplishment> Accomplishments { get; set; }
        public IEnumerable<Language> Languages { get; set; }

    }
}
