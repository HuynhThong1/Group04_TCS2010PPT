using FGW_Management.Data;
using FGW_Management.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PusherServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FGW_Management.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<FGW_User> _userManager;
        public MessageController(ApplicationDbContext context, UserManager<FGW_User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet("{group_id}")]
        public IEnumerable<Message> GetById(int group_id)
        {
            return _context.Message.Where(gb => gb.GroupId == group_id);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MessageViewModel message)
        {
            Message new_message = new Message { AddedBy = _userManager.GetUserName(User), message = message.message, GroupId = message.GroupId };

            _context.Message.Add(new_message);
            _context.SaveChanges();

            var options = new PusherOptions
            {
                Cluster = "ap1",
                Encrypted = true
            };
            var pusher = new Pusher(
                "1189814",
                "957b6e8e762fe7ef9ff6",
                "900e2a6a25b98e15c72c",
                options
            );
            var result = await pusher.TriggerAsync(
                "private-" + message.GroupId,
                "new_message",
            new { new_message },
            new TriggerOptions() { SocketId = message.SocketId });
            return new ObjectResult(new { status = "success", data = new_message });
        }
    }
}
