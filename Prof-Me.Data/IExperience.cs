using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prof_Me.Data
{
    public interface IExperience<UserEntity>
    {
        UserEntity GetExperience(int id);
        IEnumerable<UserEntity> GetAllExperience();
        Task AddExperienceData(UserEntity entity);
        Task UpdateExperienceData(UserEntity dbentity, UserEntity entity);
        Task DeleteExperience(UserEntity entity);
    }
}
