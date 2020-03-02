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
    public class AccomplishmentsController : Controller
    {
        private readonly IAccomplishment<Accomplishment> _context;
        private readonly UserManager<UserData> _userManager;
        private readonly IUserProfile<UserProfile> _profilecontext;

        public AccomplishmentsController(IAccomplishment<Accomplishment> context,
            IUserProfile<UserProfile> profilecontext,
            UserManager<UserData> userManager)
        {
            _context = context;
            _profilecontext = profilecontext;
            _userManager = userManager;
        }

        // GET: Accomplishments
        public IActionResult Index()
        {
            return View(_context.GetAllAccomplishment());
        }

        // GET: Accomplishments/Details/5
        public IActionResult Details(int id)
        {


            var accomplishment = _context.GetAccomplishment(id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // GET: Accomplishments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accomplishments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CertificateName,GotDate")] Accomplishment accomplishment)
        {
            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);
                var user = _profilecontext.GetUser(current_User.UserName);
                accomplishment.User = user;
                await _context.AddAccomplishmentData(accomplishment);
                TempData["smessage"] = "Added New Accomplishment Sucessfully";
                return RedirectToAction("MyProfile", "UserProfiles", new { @username = current_User.UserName });
            }
            return View(accomplishment);
        }

        // GET: Accomplishments/Edit/5
        public IActionResult Edit(int id)
        {
         

            var accomplishment = _context.GetAccomplishment(id);
            if (accomplishment == null)
            {
                return NotFound();
            }
            return View(accomplishment);
        }

        // POST: Accomplishments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CertificateName,GotDate")] Accomplishment accomplishment)
        {
            if (id != accomplishment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var current_User = await _userManager.GetUserAsync(HttpContext.User);

                try
                {
                    var toupdate = _context.GetAccomplishment(id);
                    await _context.UpdateAccomplishmentData(toupdate, accomplishment);
                    TempData["smessage"] = "Updated Accomplishment Sucessfully";

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccomplishmentExists(accomplishment.Id))
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
            return View(accomplishment);
        }

        // GET: Accomplishments/Delete/5
        public IActionResult Delete(int id)
        {
            

            var accomplishment = _context.GetAccomplishment(id);
            if (accomplishment == null)
            {
                return NotFound();
            }

            return View(accomplishment);
        }

        // POST: Accomplishments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accomplishment = _context.GetAccomplishment(id);
           await _context.DeleteAccomplishment(accomplishment);
            TempData["smessage"] = "Deleted Accomplishment Sucessfully";

            return RedirectToAction(nameof(Index));
        }

        private bool AccomplishmentExists(int id)
        {
           if(_context.GetAccomplishment(id) != null)
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
