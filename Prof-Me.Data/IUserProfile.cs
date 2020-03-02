using System.Collections.Generic;

namespace Prof_Me.Data
{
    public interface IUserProfile<UserEntity>
    {

        UserEntity GetUser(int id);
        UserEntity GetUser(string username);
        IEnumerable<UserEntity> GetAllUser(string SearchString);
        void AddProfileData(UserEntity entity);
        void UpdateProfileData(UserEntity dbentity, UserEntity entity);
        void DeleteProfile(UserEntity entity);

    }
}
