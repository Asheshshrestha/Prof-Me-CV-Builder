using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prof_Me.Services
{
    public class ExperienceServices : IExperience<Experience>
    {
        readonly UserProfileDbContext _context;

        public ExperienceServices(UserProfileDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Experience> GetAllExperience()
        {
            return _context.Experiences.ToList();
        }

        public Experience GetExperience(int id)
        {
            return _context.Experiences.FirstOrDefault(e => e.Id == id);
        }
        public async Task AddExperienceData(Experience experience)
        {
            _context.Experiences.Add(experience);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateExperienceData(Experience dbexperience, Experience experience)
        {
            dbexperience.Company = experience.Company;
            dbexperience.PostType = experience.PostType;
            dbexperience.Description = experience.Description;
            dbexperience.Join = experience.Join;
            dbexperience.Leave = experience.Leave;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteExperience(Experience experience)
        {
            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
        }

    }
}
