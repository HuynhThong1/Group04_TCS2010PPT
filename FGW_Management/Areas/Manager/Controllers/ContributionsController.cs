using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FGW_Management.Data;
using FGW_Management.Models;
using System.Security.Claims;
using System.IO;
using System.IO.Compression;
using System.Net.Mime;

namespace FGW_Management.Areas.Manager.Views
{
    [Area("Manager")]
    public class ContributionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContributionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Manager/Contributions
        public async Task<IActionResult> Index(int submissionId)
        {
            var contributions = await _context.Contributions.Include(c => c.Submission)
                                                           .Include(c => c.Contributor)
                                                           .Where(c => c.SubmissionId == submissionId)
                                                           .ToListAsync();

            ViewData["TopicId"] = submissionId;
            contributions = contributions.Where(c => c.Status == ContributionStatus.Approved).ToList();
            return View(contributions);

        }

        // GET: Manager/Contributions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contribution = await _context.Contributions
                .Include(c => c.Contributor)
                .Include(c => c.Submission)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contribution == null)
            {
                return NotFound();
            }

            return View(contribution);
        }

        public async Task<ActionResult> DownloadApprovedFile(int topicId = -1)
        {
            var approvedContributions = await _context.Contributions.Include(c => c.Contributor)
                                                                    .Include(c => c.SubmittedFiles)
                                                                    .Where(c => c.SubmissionId == topicId
                                                                    && c.Status == ContributionStatus.Approved).ToListAsync();

            if (approvedContributions.Count() > 0)
            {
                var topic = await _context.Submissions.FindAsync(topicId);
                var zipPath = Path.Combine(_Global.PATH_TOPIC, topicId.ToString(), topic.Title + ".zip");

                using (FileStream zipToOpen = new FileStream(zipPath, FileMode.Create))
                {
                    using (ZipArchive achive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        foreach (var contribution in approvedContributions)
                        {
                            foreach (var file in contribution.SubmittedFiles)
                            {
                                achive.CreateEntryFromFile(file.URL, Path.Combine(contribution.Contributor.Number
                                                                                    , Path.GetFileName(file.URL)));
                            }
                        }
                    }
                }

                byte[] fileBytes = System.IO.File.ReadAllBytes(zipPath);

                System.IO.File.Delete(zipPath);


                return File(fileBytes, MediaTypeNames.Application.Zip, Path.GetFileName(zipPath));
            }

            return NoContent();
        }

        public async Task<ActionResult> DownloadFile(int fileId = -1)
        {
            var file = await _context.SubmittedFiles.FindAsync(fileId);
            byte[] fileBytes = System.IO.File.ReadAllBytes(file.URL);
            return File(fileBytes, MediaTypeNames.Application.Octet, Path.GetFileName(file.URL));
        }

        private bool ContributionExists(int id)
        {
            return _context.Contributions.Any(e => e.Id == id);
        }
    }
}
