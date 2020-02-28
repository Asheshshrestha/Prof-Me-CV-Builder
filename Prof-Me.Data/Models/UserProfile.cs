using System.Collections.Generic;

namespace Prof_Me.Data.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string CoverImage { get; set; }
        public string ProfileImage { get; set; }

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
