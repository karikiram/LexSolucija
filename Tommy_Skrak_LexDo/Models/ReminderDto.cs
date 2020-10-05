using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tommy_Skrak_LexDo.Areas.Identity.Data;

namespace Tommy_Skrak_LexDo.Models
{
	public class ReminderDto
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public DateTime Date { get; set; }
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
		public int GroupId { get; set; }
		public string Group { get; set; }
	}
}
