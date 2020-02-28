using System.Collections.Generic;

namespace Prof_Me.Data
{
    public interface IAccomplishment<UserEntity>
    {
        UserEntity GetAccomplishment(int id);
        IEnumerable<UserEntity> GetAllAccomplishment();
        void AddAccomplishmentData(UserEntity entity);
        void UpdateAccomplishmentData(UserEntity dbentity, UserEntity entity);
        void DeleteAccomplishment(UserEntity entity);
    }
}
