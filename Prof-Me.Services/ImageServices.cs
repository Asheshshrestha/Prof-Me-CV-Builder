using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.IO;
namespace Prof_Me.Services
{
    public class ImageServices : IImageSave<ImageFile>
    {
        private readonly UserManager<UserData> _userManager;
        readonly UserProfileDbContext _context;
        public ImageServices(UserProfileDbContext context,
            UserManager<UserData> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public string SaveProfileImage(IFormFile image)
        {
           
                var fileName = Path.GetFileName(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\userimage", fileName);
                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileSteam);
                }
                var tosave = new ImageFile { Image = fileName };
                _context.Add(tosave);
                _context.SaveChanges();
                return (fileName);
        
        }
        public string SaveCoverImage(IFormFile image)
        {
            
                var fileName = Path.GetFileName(image.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\userimage", fileName);
                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileSteam);
                }

                var tosave = new ImageFile { Image = fileName };
                _context.Add(tosave);
                _context.SaveChanges();
                return (fileName);
            
           
        }
    }
}
