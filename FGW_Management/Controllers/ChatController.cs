using FGW_Management.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FGW_Management.Models;

namespace FGW_Management.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly UserManager<FGW_User> _userManager;
        private readonly ApplicationDbContext _GroupContext;
        public ChatController(
          UserManager<FGW_User> userManager,
          ApplicationDbContext context
          )
        {
            _userManager = userManager;
            _GroupContext = context;
        }

        public IActionResult Index()
        {
            var groups = _GroupContext.UserGroup
                       .Where(gp => gp.UserName == _userManager.GetUserName(User))
                       .Join(_GroupContext.Groups, ug => ug.GroupId, g => g.ID, (ug, g) =>
                               new UserGroupViewModel
                               {
                                   UserName = ug.UserName,
                                   GroupId = g.ID,
                                   GroupName = g.GroupName
                               })
                       .ToList();

            ViewData["UserGroups"] = groups;

            // get all users      
            ViewData["Users"] = _userManager.Users;
            return View();
        }
    }
}
