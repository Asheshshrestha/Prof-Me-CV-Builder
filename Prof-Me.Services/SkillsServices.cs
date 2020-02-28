using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Prof_Me.Services
{
    public class SkillsServices : ISkills<Skills>
    {
        readonly UserProfileDbContext _context;
        public SkillsServices(UserProfileDbContext context)
        {
            _context = context;
        }
        public Skills GetSkill(int id)
        {
            return _context.Skills.FirstOrDefault(p => p.Id == id);

        }
        public IEnumerable<Skills> GetAllSkill()
        {
            return _context.Skills.ToList();
        }
        public void AddSkillsData(Skills skill)
        {
            _context.Add(skill);
            _context.SaveChanges();
        }
        public void UpdateSkillsData(Skills dbskill, Skills skill)
        {
            dbskill.SkillName = skill.SkillName;
            _context.SaveChanges();
        }

        public void DeleteSkills(Skills skill)
        {
            _context.Skills.Remove(skill);
            _context.SaveChanges();
        }
    }
}
