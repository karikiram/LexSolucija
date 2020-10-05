using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tommy_Skrak_LexDo.Areas.Identity.Data;
using Tommy_Skrak_LexDo.Models;

namespace Tommy_Skrak_LexDo.Data
{
	public class AuthDBContext : IdentityDbContext<ApplicationUser>
	{
		public AuthDBContext(DbContextOptions<AuthDBContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Reminder>()
					.HasOne(p => p.User)
					.WithMany(b => b.Reminders);

		}


		public DbSet<ApplicationUser> User { get; set; }

		public DbSet<Reminder> Reminder { get; set; }

		public DbSet<Group> Group { get; set; }
	}
}
