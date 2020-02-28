using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;
namespace Prof_Me.Services
{
    public class EducationServices : IEducation<Education>
    {
        readonly UserProfileDbContext _context;
        public EducationServices(UserProfileDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Education> GetAllEducation()
        {
            return _context.Educations.ToList();
        }
        public Education GetEducation(int id)
        {
            return _context.Educations.FirstOrDefault(e => e.Id == id);
        }
        public void AddEducationData(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
        }
        public void UpdateEducationData(Education education, Education entity)
        {
            education.EName = entity.EName;
            education.Level = entity.Level;
            education.Join = entity.Join;
            education.Leave = entity.Leave;
            _context.SaveChanges();
        }
        public void DeleteEducation(Education education)
        {
            _context.Educations.Remove(education);
            _context.SaveChanges();
        }
    }
}
