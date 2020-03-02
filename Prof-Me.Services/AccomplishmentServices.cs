using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prof_Me.Services
{
    public class AccomplishmentServices : IAccomplishment<Accomplishment>
    {
        readonly UserProfileDbContext _context;
        public AccomplishmentServices(UserProfileDbContext context)
        {
            _context = context;
        }

        public async Task AddAccomplishmentData(Accomplishment entity)
        {
            _context.Accomplishments.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAccomplishment(Accomplishment entity)
        {
            _context.Accomplishments.Remove(entity);
           await  _context.SaveChangesAsync();
        }

        public Accomplishment GetAccomplishment(int id)
        {
            return _context.Accomplishments.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Accomplishment> GetAllAccomplishment()
        {
            return _context.Accomplishments.ToList();
        }

        public async Task UpdateAccomplishmentData(Accomplishment dbentity, Accomplishment entity)
        {
            dbentity.CertificateName = entity.CertificateName;
            dbentity.GotDate = entity.GotDate;
            await _context.SaveChangesAsync();
        }

    }
}
