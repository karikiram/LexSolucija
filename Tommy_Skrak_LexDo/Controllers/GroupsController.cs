using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tommy_Skrak_LexDo.Areas.Identity.Data;
using Tommy_Skrak_LexDo.Data;
using Tommy_Skrak_LexDo.Models;

namespace Tommy_Skrak_LexDo.Controllers
{
	[Authorize]
	public class GroupsController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AuthDBContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		public GroupsController(ILogger<HomeController> logger, AuthDBContext context, UserManager<ApplicationUser> userManager)
		{
			_logger = logger;
			_context = context;
			_userManager = userManager;
		}
		public IActionResult Index()
		{
			return View();
		}

		//[HttpGet("DeleteGroup/{id}")]
		//public IActionResult Delete(int? id)
		//{
		//	Group group = _context.Group.Find(id);
		//	_context.Group.Remove(group);
		//	_context.SaveChanges();
		//	return RedirectToAction("Index", "Home");
		//}

		[HttpGet("CreateGroup")]
		public IActionResult CreateGroup()
		{
			Group group = new Group();
			return PartialView("_GroupModelPartial", group);
		}

		[HttpPost("CreateGroup")]
		public IActionResult CreateGroup(GroupDto groupDto)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var group = new Group
			{
				Name = groupDto.Name,
				UserId = userId
			};

			_context.Add(group);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet("EditGroup/{id}")]
		public IActionResult EditGroup(int id)
		{
			var group = _context.Group.Where(x => x.Id == id).FirstOrDefault();
			return PartialView("_EditGroupModelPartial", group);
		}

		[HttpPost("EditGroup")]
		public IActionResult EditGroup(Group group)
		{
			_context.Group.Update(group);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}
	}
}
