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
    public class SkillsController : Controller
    {
        private readonly UserManager<UserData> _userManager;
        private readonly IUserProfile<UserProfile> _profilecontext;

        private readonly ISkills<Skills> _context;

        public SkillsController(ISkills<Skills> context,
            UserManager<UserData> userManager,
            IUserProfile<UserProfile> profilecontext)
        {
            _context = context;
            _userManager = userManager;
            _profilecontext = profilecontext;
        }

        // GET: Skills
        public IActionResult Index()
        {
            return View(_context.GetAllSkill());
        }

        // GET: Skills/Details/5
        public IActionResult Details(int id)
        {


            var skills = _context.GetSkill(id);
            if (skills == null)
            {
                return NotFound();
            }

            return View(skills);
        }

        // GET: Skills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SkillName")] Skills skills)
        {
            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                var user = _profilecontext.GetUser(current_User.UserName);
                    skills.User = user;
                _context.AddSkillsData(skills);
                TempData["smessage"] = "Added New Skill Sucessfully";

                return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
            }
            return View(skills);
        }

        // GET: Skills/Edit/5
        public IActionResult Edit(int id)
        {
            
            var skills = _context.GetSkill(id);
            if (skills == null)
            {
                return NotFound();
            }
            return View(skills);
        }

        // POST: Skills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SkillName")] Skills skills)
        {
            if (id != skills.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);

                try
                {
                    var toupdate = _context.GetSkill(id);
                    _context.UpdateSkillsData(toupdate, skills);
                    TempData["smessage"] = "Updated Skill Sucessfully";


                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillsExists(skills.Id))
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
            return View(skills);
        }

        // GET: Skills/Delete/5
        public IActionResult Delete(int id)
        {


            var skills = _context.GetSkill(id);

            if (skills == null)
            {
                return NotFound();
            }

            return View(skills);
        }

        // POST: Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var current_User = await _userManager.GetUserAsync(HttpContext.User);
            var todelete = _context.GetSkill(id);
            _context.DeleteSkills(todelete);
            TempData["smessage"] = "Deleted Skill Sucessfully";

            return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
        }

        private bool SkillsExists(int id)
        {
           if(_context.GetSkill(id) != null)
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
