using Microsoft.AspNetCore.Http;
namespace Prof_Me.Data
{
    public interface IImageSave<UserEntity>
    {
        public string SaveProfileImage(IFormFile image);
        public string SaveCoverImage(IFormFile image);
    }
}
