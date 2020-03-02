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
    public class LanguagesController : Controller
    {
        private readonly ILanguage<Language> _context;
        private readonly IUserProfile<UserProfile> _profilecontext;
        private readonly UserManager<UserData> _userManager;

        public LanguagesController(ILanguage<Language> context,
            IUserProfile<UserProfile> profilecontext,
            UserManager<UserData> userManager)
        {
            _context = context;
            _profilecontext = profilecontext;
            _userManager = userManager;
        }

        // GET: Languages
        public IActionResult Index()
        {
            return View(_context.GetAllLanguage());
        }

        // GET: Languages/Details/5
        public IActionResult Details(int id)
        {


            var language = _context.GetLanguage(id);
            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // GET: Languages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Languages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LanguageName")] Language language)
        {
            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                var user = _profilecontext.GetUser(current_User.UserName);
                language.User = user;
                await _context.AddLanguageData(language);
                TempData["smessage"] = "Added New Language Sucessfully";

                return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
            }
            return View(language);
        }

        // GET: Languages/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var language = _context.GetLanguage(id);
            if (language == null)
            {
                return NotFound();
            }
            return View(language);
        }

        // POST: Languages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LanguageName")] Language language)
        {
            if (id != language.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);

                try
                {
                    var toupdate = _context.GetLanguage(id);
                    await _context.UpdateLanguageData(toupdate, language);
                    TempData["smessage"] = "Updated Language Sucessfully";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanguageExists(language.Id))
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
            return View(language);
        }

        // GET: Languages/Delete/5
        public IActionResult Delete(int id)
        {
           

            var language = _context.GetLanguage(id);
            if (language == null)
            {
                return NotFound();
            }

            return View(language);
        }

        // POST: Languages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var current_User = await _userManager.GetUserAsync(HttpContext.User);
            var todelete = _context.GetLanguage(id);
            await _context.DeleteLanguage(todelete);
            TempData["smessage"] = "Deleted Language Sucessfully";
            return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
        }

        private bool LanguageExists(int id)
        {

            if (_context.GetLanguage(id) != null)
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
