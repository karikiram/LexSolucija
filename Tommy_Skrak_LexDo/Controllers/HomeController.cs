using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using Tommy_Skrak_LexDo.Areas.Identity.Data;
using Tommy_Skrak_LexDo.Data;
using Tommy_Skrak_LexDo.Models;
using PagedList;

namespace Tommy_Skrak_LexDo.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly AuthDBContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly IMapper _mapper;
		public HomeController(ILogger<HomeController> logger, AuthDBContext context, UserManager<ApplicationUser> userManager, IMapper mapper)
		{
			_logger = logger;
			_context = context;
			_userManager = userManager;
			_mapper = mapper;
		}
		public IActionResult Index(int? filter, string sortOrder, string command)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "Date" : "";
			ViewBag.TitleSortParm = sortOrder == "Title" ? "title_desc" : "Title";
			var grouplist = _context.Group.Where(x => x.UserId == userId).ToList();
			ViewBag.TotalGroups = grouplist;
			var reminders = from r in _context.Reminder select r;
			if(command == null)
			{
				command = "";
			}

			if(command.Equals("Delete"))
			{
				Group group = _context.Group.Find(filter);
				_context.Group.Remove(group);
				_context.SaveChanges();
				return RedirectToAction("Index", "Home");
			}
			else { 
			if (filter != null)
			{
				reminders = reminders.Where(x => x.GroupId == filter);
			}
			}
			switch (sortOrder)
			{
				case "title_desc":
					reminders = reminders.OrderByDescending(s => s.Title);
					break;
				case "Date":
					reminders = reminders.OrderBy(s => s.Date);
					break;
				case "Title":
					reminders = reminders.OrderBy(s => s.Title);
					break;
				default:
					reminders = reminders.OrderByDescending(s => s.Date);
					break;
			}

			return View(reminders.ToList());

		}

		[HttpPost]
		public async Task<IActionResult> ExportExcelAsync()
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var myReminders = await _context.Reminder.Where(x => x.UserId == userId).ToListAsync();
			var excelReminders = _mapper.Map<List<ExcelReminder>>(myReminders);
			var stream = new MemoryStream();

			using (var package = new ExcelPackage(stream))
			{
				var workSheet = package.Workbook.Worksheets.Add("Sheet1");
				workSheet.Cells.LoadFromCollection(excelReminders, true);
				package.Save();
			}
			stream.Position = 0;

			string excelName = $"Reminders-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";

			return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
		}

	}
}
