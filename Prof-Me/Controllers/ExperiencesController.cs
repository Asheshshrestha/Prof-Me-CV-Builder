using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prof_Me.Data;
using Prof_Me.Data.Models;
using System.Threading.Tasks;

namespace Prof_Me.Controllers
{
    public class ExperiencesController : Controller
    {
        private readonly UserManager<UserData> _userManager;

        private readonly IExperience<Experience> _context;
        private readonly IUserProfile<UserProfile> _profilecontext;

        public ExperiencesController(IExperience<Experience> context,
            IUserProfile<UserProfile> profilecontext,
            UserManager<UserData> userManager)
        {
            _context = context;
            _userManager = userManager;
            _profilecontext = profilecontext;
        }
       
        // GET: Experiences
        public IActionResult Index()
        {
            return View(_context.GetAllExperience());
        }

        // GET: Experiences/Details/5
        public IActionResult Details(int id)
        {


            var experience = _context.GetExperience(id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // GET: Experiences/Create
        public IActionResult Create()
        {
            return View();
        }
        public async Task<UserData> GetUser()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }

        // POST: Experiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateAsync([Bind("Id,Company,PostType,Join,Leave,Description")] Experience experience)
        {
            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                var user = _profilecontext.GetUser(current_User.UserName);
                experience.User = user;
                await _context.AddExperienceData(experience);

                return RedirectToAction("MyProfile","UserProfiles",new { @username = current_User.UserName });
            }
            return View(experience);
        }

        // GET: Experiences/Edit/5
        public IActionResult Edit(int id)
        {

            var experience = _context.GetExperience(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }

        // POST: Experiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Company,PostType,Join,Leave,Description")] Experience experience)
        {
            if (id != experience.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                try
                {
                    
                    var toupdate = _context.GetExperience(id);
                    await _context.UpdateExperienceData(toupdate, experience);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienceExists(experience.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
            }
            return View(experience);
        }

        // GET: Experiences/Delete/5
        public IActionResult Delete(int id)
        {

            var experience = _context.GetExperience(id);
            if (experience == null)
            {
                return NotFound();
            }

            return View(experience);
        }

        // POST: Experiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var current_User = await _userManager.GetUserAsync(HttpContext.User);
            var todelete = _context.GetExperience(id);
            await _context.DeleteExperience(todelete);
            return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
        }

        private bool ExperienceExists(int id)
        {
            if (_context.GetExperience(id) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
