using System.Collections.Generic;

namespace Prof_Me.Data
{
    public interface ILanguage<UserEntity>
    {
        UserEntity GetLanguage(int id);
        IEnumerable<UserEntity> GetAllLanguage();
        void AddLanguageData(UserEntity entity);
        void UpdateLanguageData(UserEntity dbentity, UserEntity entity);
        void DeleteLanguage(UserEntity entity);
    }
}
