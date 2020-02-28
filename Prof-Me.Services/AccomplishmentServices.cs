using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Prof_Me.Services
{
    public class AccomplishmentServices : IAccomplishment<Accomplishment>
    {
        readonly UserProfileDbContext _context;
        public AccomplishmentServices(UserProfileDbContext context)
        {
            _context = context;
        }

        public void AddAccomplishmentData(Accomplishment entity)
        {
            _context.Accomplishments.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteAccomplishment(Accomplishment entity)
        {
            _context.Accomplishments.Remove(entity);
            _context.SaveChanges();
        }

        public Accomplishment GetAccomplishment(int id)
        {
            return _context.Accomplishments.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Accomplishment> GetAllAccomplishment()
        {
            return _context.Accomplishments.ToList();
        }

        public void UpdateAccomplishmentData(Accomplishment dbentity, Accomplishment entity)
        {
            dbentity.CertificateName = entity.CertificateName;
            dbentity.GotDate = entity.GotDate;
            _context.SaveChanges();
        }

    }
}
