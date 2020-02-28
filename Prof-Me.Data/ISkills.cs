using Prof_Me.Data.Models;
using System.Collections.Generic;

namespace Prof_Me.Data
{
    public interface ISkills<UserEntity>
    {
        UserEntity GetSkill(int id);
        IEnumerable<UserEntity> GetAllSkill();
        void AddSkillsData(UserEntity entity);
        void UpdateSkillsData(UserEntity dbentity, UserEntity entity);
        void DeleteSkills(UserEntity entity);
       
    }
}
