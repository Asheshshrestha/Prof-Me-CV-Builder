using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Prof_Me.Services;
using Prof_Me.Data;
using Prof_Me.Data.Models;
using Prof_Me.Controllers;
using Moq;
using Microsoft.AspNetCore.Identity;

namespace Prof_Me.Services.Test
{

    
    public class UserProfileServicesTest 
    {
        private readonly UserProfileServices _context;
        private readonly Mock<UserProfileDbContext> _mockcontext;

        public UserProfileServicesTest()
        {
            _mockcontext = new Mock<UserProfileDbContext>();
            

        }
        [Theory]
       [InlineData(1, "asheshshrestha")]
       [InlineData(2, "janakmahato")]
       [InlineData(3, "agammahato")]
       public void GetUserByIdTest(int id, string name)
        {
            _mockcontext.Setup(p => p.UserProfiles.Find(id).UserName).Returns(name);
            
            var username = _context.GetUser(id).UserName;




            Assert.Equal(name, username);


        }


    }
}
