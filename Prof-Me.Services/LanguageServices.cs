using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Collections.Generic;
using System.Linq;

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
        public void AddLanguageData(Language language)
        {
            _context.Languages.Add(language);
            _context.SaveChanges();
        }
        public void UpdateLanguageData(Language dblanguage, Language language)
        {
            dblanguage.Id = language.Id;
            dblanguage.LanguageName = language.LanguageName;
            _context.SaveChanges();
        }
        public void DeleteLanguage(Language language)
        {
            _context.Languages.Remove(language);
            _context.SaveChanges();
        }


    }
}
