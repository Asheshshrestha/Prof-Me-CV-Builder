using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prof_Me.Data
{
    public interface ILanguage<UserEntity>
    {
        UserEntity GetLanguage(int id);
        IEnumerable<UserEntity> GetAllLanguage();
        Task AddLanguageData(UserEntity entity);
        Task UpdateLanguageData(UserEntity dbentity, UserEntity entity);
        Task DeleteLanguage(UserEntity entity);
    }
}
