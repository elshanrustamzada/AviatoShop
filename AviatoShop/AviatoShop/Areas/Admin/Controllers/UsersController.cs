using AviatoShop.Models;
using AviatoShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AviatoShop.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles ="Admin")]
	public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly SignInManager<AppUser> _signInManager;


        public UsersController(UserManager<AppUser> userManager,
                               RoleManager<IdentityRole> roleManager
                              /* SignInManager<AppUser> signInManager*/)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            //_signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> dbUsers = await _userManager.Users.ToListAsync();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (AppUser dbUser in dbUsers)
            {
                UserVM userVM = new()
                {
                    Id = dbUser.Id,
                    Fullname = dbUser.Name + " " + dbUser.Surname,
                    Username = dbUser.UserName,
                    Email = dbUser.Email,
                    IsDeactive = dbUser.IsDeactive,
                    Role = (await _userManager.GetRolesAsync(dbUser))[0]
                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }
    }
}
