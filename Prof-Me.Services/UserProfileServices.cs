using Microsoft.EntityFrameworkCore;
using Prof_Me.Data;
using Prof_Me.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prof_Me.Services
{
    public class UserProfileServices : IUserProfile<UserProfile>
    {
        readonly UserProfileDbContext _context;
        public UserProfileServices(UserProfileDbContext context)
        {
            _context = context;
        }
       
        public void AddProfileData(UserProfile entity)
        {
            _context.UserProfiles.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteProfile(UserProfile entity)
        {
            _context.UserProfiles.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<UserProfile> GetAllUser(string SearchString)
        {
            var users = from m in _context.UserProfiles
                         select m;
            if (!String.IsNullOrEmpty(SearchString))
            {
                users = users.Where(s => s.UserName.Contains(SearchString) 
                || s.Age.ToString().Contains(SearchString)
                || s.Universiy.Contains(SearchString)
                || s.Company.Contains(SearchString)
                || s.Post.Contains(SearchString));
            }
            return users.ToList();
        }

        public UserProfile GetUser(int id)
        {
            return _context.UserProfiles
                .Include(p => p.Experiences)
                .Include(p => p.Educations)
                .Include(p => p.Skills)
                .Include(p => p.Accomplishments)
                .Include(p => p.Languages)
                .FirstOrDefault(p => p.Id == id);
        }

        public UserProfile GetUser(string username)
        {
            return _context.UserProfiles
                .Include(p => p.Experiences)
                .Include(p => p.Educations)
                .Include(p=>p.Skills)
                .Include(p => p.Accomplishments)
                .Include(p => p.Languages)
                .FirstOrDefault(p => p.UserName == username);
        }

        public void UpdateProfileData(UserProfile dbentity, UserProfile entity)
        {
            dbentity.FName = entity.FName;
            dbentity.LName = entity.LName;
            dbentity.Address = entity.Address;
            dbentity.Age = entity.Age;
            dbentity.Universiy = entity.Universiy;
            dbentity.Company = entity.Company;
            dbentity.Post = entity.Post;
            dbentity.ProfileImage = entity.ProfileImage;
            dbentity.CoverImage = entity.CoverImage;
            _context.SaveChanges();
        }
    }
}
