using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Threading.Tasks;

namespace Prof_Me.Controllers
{
    public class UserProfilesController : Controller
    {
        private readonly IUserProfile<UserProfile> _context;
        private readonly UserManager<UserData> _userManager;
        private readonly IImageSave<ImageFile> _imgcontext;

        public UserProfilesController(IUserProfile<UserProfile> context,
            UserManager<UserData> userManager,
            IImageSave<ImageFile> imgcontext)
        {
            _context = context;
            _userManager = userManager;
            _imgcontext = imgcontext;
        }

        // GET: UserProfiles
        [Authorize]
        public IActionResult Index()
        {
            return View(_context.GetAllUser());
        }

        // GET: UserProfiles/Details/5
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var current_User = await _userManager.GetUserAsync(HttpContext.User);
            var user = _context.GetUser(current_User.UserName);
            ViewBag.Username = user.Id;
            var userProfile = _context.GetUser(id);
            if (userProfile == null)
            {
                return NotFound();
            }

            return View(userProfile);
        }
        [Authorize]
        [Route("UserProfiles/MyProfile/{username}")]
        public IActionResult MyProfile(string username)
        {
            if (username == null)
            {
                return NotFound();
            }
            var user = _context.GetUser(username);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);

        }



        // GET: UserProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,UserName,FName,LName,Address,Age,Universiy,Company,Post")] UserProfile userProfile, IFormFile CoverImage, IFormFile ProfileImage)
        {
            if (ModelState.IsValid)
            {
                userProfile.CoverImage = _imgcontext.SaveCoverImage(CoverImage);
                userProfile.ProfileImage = _imgcontext.SaveProfileImage(ProfileImage);
                _context.AddProfileData(userProfile);


                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        // GET: UserProfiles/Edit/5
        public IActionResult Edit(int id)
        {
          
            var userProfile = _context.GetUser(id);
            if (userProfile == null)
            {
                return NotFound();
            }
            return View(userProfile);
        }

        // POST: UserProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,UserName,FName,LName,Address,Age,Universiy,Company,Post,ProfileImage,CoverImage")] UserProfile userProfile, IFormFile ProfileImage, IFormFile CoverImage)
        {
            if (id != userProfile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var dbdata = _context.GetUser(id);
                    if (CoverImage != null && CoverImage.Length > 0)
                    {
                        userProfile.CoverImage = _imgcontext.SaveCoverImage(CoverImage);
                    }
                    if (ProfileImage != null && ProfileImage.Length > 0)
                    {
                        userProfile.ProfileImage = _imgcontext.SaveProfileImage(ProfileImage);
                    }
                        _context.UpdateProfileData(dbdata, userProfile);
                    

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserProfileExists(userProfile.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userProfile);
        }

        // GET: UserProfiles/Delete/5
        public IActionResult Delete(int id)
        {
           
            var userProfile = _context.GetUser(id);
            if (userProfile == null)
            {
                return NotFound();
            }

            return View(userProfile);
        }

        // POST: UserProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var userProfile = _context.GetUser(id);
            _context.DeleteProfile(userProfile);
            return RedirectToAction(nameof(Index));
        }

        private bool UserProfileExists(int id)
        {
            if (_context.GetUser(id) != null)
                return true;
            else
            {
                return false;
            }
        }
    }
}
