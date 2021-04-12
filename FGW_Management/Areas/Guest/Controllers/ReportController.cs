using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FGW_Management.Data;
using Microsoft.EntityFrameworkCore;
using FGW_Management.Models;

namespace FGW_Management.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int ITDepartmentId = 1, int BusinesDepartmentId = 2, int EventDepartmentId = 3)
        {
            var studentIds = await _context.UserRoles.Where(u => u.RoleId == "Student").
                                                      Select(u => u.UserId)
                                                      .ToListAsync();

            var students = await _context.Users.Where(u => studentIds.Contains(u.Id)).ToListAsync();
            var studentofITDepartment = students.Where(s => s.DepartmentId == ITDepartmentId).ToList();
            var studentofEventDepartment = students.Where(s => s.DepartmentId == EventDepartmentId).ToList();
            var studentofBusinessDepartment = students.Where(s => s.DepartmentId == BusinesDepartmentId).ToList();
            var numOfDept = await _context.Departments.CountAsync();
            var numOfContributions = await _context.Contributions.CountAsync();

            var approvedContribution = await _context.Contributions.Where(c => c.Status == ContributionStatus.Approved).CountAsync(); 

            ViewData["TotalStudent"] = students.Count();
            ViewData["TotalStudentofITDept"] = studentofITDepartment.Count();
            ViewData["TotalStudentofEventDept"] = studentofEventDepartment.Count();
            ViewData["TotalStudentofBusinessDept"] = studentofBusinessDepartment.Count();
            ViewData["TotalDepartment"] = numOfDept - 1;
            ViewData["TotalContributions"] = numOfContributions;
            ViewData["ApprovedContributions"] = approvedContribution; 
            return View();
        }
    }
}
