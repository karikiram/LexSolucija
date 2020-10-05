using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tommy_Skrak_LexDo.Data;
using Tommy_Skrak_LexDo.Models;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;

namespace Tommy_Skrak_LexDo.Controllers
{
	[Authorize]
	public class RemindersController : Controller
	{
		private readonly AuthDBContext _context;

		public RemindersController(AuthDBContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("Delete/{id}")]
		public IActionResult Delete(int? id)
		{
			Reminder reminder = _context.Reminder.Find(id);
			_context.Reminder.Remove(reminder);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet("Create")]
		public IActionResult Create()
		{
			var grouplist = _context.Group.ToList();
			ViewBag.TotalGroups = grouplist;
			Reminder reminder = new Reminder();
			return PartialView("_ReminderModelPartial", reminder);
		}

		[HttpPost("Create")]
		public IActionResult Create(ReminderDto reminderDto)
		{
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var reminder = new Reminder
			{
				Title = reminderDto.Title,
				Description = reminderDto.Description,
				Date = DateTime.Now,
				Status = reminderDto.Status,
				GroupId = reminderDto.GroupId,
				UserId = userId
			};
			_context.Add(reminder);
			_context.SaveChanges();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet("Edit/{id}")]
		public IActionResult Edit(int id)
		{
			var grouplist = _context.Group.ToList();
			ViewBag.TotalGroups = grouplist;
			var reminder = _context.Reminder.Where(x => x.Id == id).FirstOrDefault();
			return PartialView("_EditReminderModelPartial", reminder);
		}

		[HttpPost("Edit")]
		public IActionResult Edit(Reminder rem)
		{
			// pokušaj vremena potrebnog za izvršit podsjetnik (radi, ali ne ispisuje)
			if (rem.Status == true)
			{
				var firstTime = rem.Date;
				var oldReminder = _context.Reminder.FirstOrDefault(x => x.UserId == rem.UserId);
				var secondTime = oldReminder.Date;
				var timeNeeded = firstTime - secondTime;
				_context.Reminder.Update(rem);
				_context.SaveChanges();
				return RedirectToAction("Index", "Home", timeNeeded);
			}
			else
			{
				_context.Reminder.Update(rem);
				_context.SaveChanges();
				return RedirectToAction("Index", "Home");
			}
		}

	}
}
