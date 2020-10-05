using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tommy_Skrak_LexDo.Areas.Identity.Data;

namespace Tommy_Skrak_LexDo.Models
{
	public class GroupDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
	}
}
