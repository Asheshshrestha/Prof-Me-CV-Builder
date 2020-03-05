using System.Collections.Generic;

namespace Prof_Me.Data
{

    /// <summary>
    /// User Profile Interface
    /// </summary>
    /// <typeparam name="UserEntity"></typeparam>
    public interface IUserProfile<UserEntity>
    {
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id">afdafadff</param>
        /// <returns></returns>
        UserEntity GetUser(int id);
        /// <summary>
        /// Get User By Username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Data of User</returns>
        UserEntity GetUser(string username);
        IEnumerable<UserEntity> GetAllUser(string SearchString);
        void AddProfileData(UserEntity entity);
        void UpdateProfileData(UserEntity dbentity, UserEntity entity);
        void DeleteProfile(UserEntity entity);

    }
}
