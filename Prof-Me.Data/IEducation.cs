using System.Collections.Generic;

namespace Prof_Me.Data
{
    public interface IEducation<UserEntity>
    {
        UserEntity GetEducation(int id);
        IEnumerable<UserEntity> GetAllEducation();
        void AddEducationData(UserEntity entity);
        void UpdateEducationData(UserEntity dbentity, UserEntity entity);
        void DeleteEducation(UserEntity entity);
    }
}
