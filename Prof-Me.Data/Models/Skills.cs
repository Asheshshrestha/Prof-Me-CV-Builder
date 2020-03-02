using System.ComponentModel.DataAnnotations;

namespace Prof_Me.Data.Models
{
    public class Skills
    {
        public int Id { get; set; }
        [Display(Name = "Skill Name")]
        public string SkillName { get; set; }
        public UserProfile User { get; set; }


    }
}
