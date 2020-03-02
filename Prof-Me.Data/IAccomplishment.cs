using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prof_Me.Data
{
    public interface IAccomplishment<UserEntity>
    {
        UserEntity GetAccomplishment(int id);
        IEnumerable<UserEntity> GetAllAccomplishment();
        Task AddAccomplishmentData(UserEntity entity);
        Task UpdateAccomplishmentData(UserEntity dbentity, UserEntity entity);
        Task DeleteAccomplishment(UserEntity entity);
    }
}
