using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Tommy_Skrak_LexDo.Models;

namespace Tommy_Skrak_LexDo.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
		[PersonalData]
		[Column(TypeName = "nvarchar(100)")]
		public string FirstName { get; set; }

		[PersonalData]
		[Column(TypeName = "nvarchar(100)")]
		public string LastName { get; set; }

		public IEnumerable<Reminder> Reminders { get; set; }
		public IEnumerable<Group> Groups { get; set; }
	}
}
