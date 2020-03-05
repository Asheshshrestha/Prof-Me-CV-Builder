using System.Collections.Generic;

namespace Prof_Me.Data
{
    /// <summary>
    /// The User Profile app service Interface
    /// </summary>
    /// <typeparam name="UserEntity"></typeparam>
    public interface IUserProfile<UserEntity>
    {
        /// <summary>
        /// Get User by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User Details</returns>
        UserEntity GetUser(int id);
        /// <summary>
        /// Get User by Username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User Details</returns>
        UserEntity GetUser(string username);
        /// <summary>
        /// Get All user And List of User Searched by User
        /// </summary>
        /// <param name="SearchString"></param>
        /// <returns>List of User</returns>
        IEnumerable<UserEntity> GetAllUser(string SearchString);
        /// <summary>
        /// Create Profile of User
        /// </summary>
        /// <param name="entity"></param>
        void AddProfileData(UserEntity entity);
        /// <summary>
        /// Update Profile of User
        /// </summary>
        /// <param name="dbentity"></param>
        /// <param name="entity"></param>
        void UpdateProfileData(UserEntity dbentity, UserEntity entity);
        /// <summary>
        /// Delete Profile of User
        /// </summary>
        /// <param name="entity"></param>
        void DeleteProfile(UserEntity entity);

    }
}
