using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prof_Me.Services
{
    public class LanguageServices : ILanguage<Language>
    {
        readonly UserProfileDbContext _context;
        public LanguageServices(UserProfileDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Language> GetAllLanguage()
        {
            return _context.Languages.ToList();
        }
        public Language GetLanguage(int id)
        {
            return _context.Languages.FirstOrDefault(p => p.Id == id);
        }
        public async Task AddLanguageData(Language language)
        {
            _context.Languages.Add(language);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateLanguageData(Language dblanguage, Language language)
        {
            dblanguage.Id = language.Id;
            dblanguage.LanguageName = language.LanguageName;
           await _context.SaveChangesAsync();
        }
        public async Task DeleteLanguage(Language language)
        {
            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();
        }


    }
}
