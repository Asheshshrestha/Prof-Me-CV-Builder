using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prof_Me.Data;
using Prof_Me.Data.Models;

namespace Prof_Me.Controllers
{
    public class EducationsController : Controller
    {
        private readonly UserManager<UserData> _userManager;
        private readonly IEducation<Education> _context;
        private readonly IUserProfile<UserProfile> _profilecontext;

        public EducationsController(IEducation<Education> context,
            UserManager<UserData> userManager,
            IUserProfile<UserProfile> profilecontext)
        {
            _context = context;
            _userManager = userManager;
            _profilecontext = profilecontext;
        }

        // GET: Educations
        public IActionResult Index()
        {
            return View(_context.GetAllEducation());
        }

        // GET: Educations/Details/5
        public IActionResult Details(int id)
        {

            var education = _context.GetEducation(id);

            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // GET: Educations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Educations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Level,EName,Join,Leave")] Education education)
        {
            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                var user = _profilecontext.GetUser(current_User.UserName);
                education.User = user;
                _context.AddEducationData(education);
                TempData["smessage"] = "Added New Education Sucessfully";

                return RedirectToAction("MyProfile","UserProfiles",new { @username = current_User.UserName });
            }
            return View(education);
        }

        // GET: Educations/Edit/5
        public IActionResult Edit(int id)
        {


            var education = _context.GetEducation(id);
            if (education == null)
            {
                return NotFound();
            }
            return View(education);
        }

        // POST: Educations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(int id, [Bind("Id,Level,EName,Join,Leave")] Education education)
        {
            if (id != education.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                try
                {
                    var toupdate = _context.GetEducation(id);
                    _context.UpdateEducationData(toupdate, education);
                    TempData["smessage"] = "Updated Education Sucessfully";

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EducationExists(education.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MyProfile","UserProfiles",new { @username = current_User.UserName });
            }
            return View(education);
        }

        // GET: Educations/Delete/5
        public IActionResult Delete(int id)
        {

            var education = _context.GetEducation(id);
            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // POST: Educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(int id)
        {
            var current_User = await _userManager.GetUserAsync(HttpContext.User);
            var education = _context.GetEducation(id);
            _context.DeleteEducation(education);
            TempData["smessage"] = "Deleted Education Sucessfully";

            return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
        }

        private bool EducationExists(int id)
        {
            if(_context.GetEducation(id) != null)
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
