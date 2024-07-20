using ApplicationApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security;

namespace ApplicationApi.DbContexts
{
	public class AppDbContext : IdentityDbContext<AppUser, Roles, string>
	{
		public DbSet<Permissions> Permissions { get; set; }
		public DbSet<RolePermission> RolePermissions { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LAPTOP-7HORMRAF\\SQLEXPRESS01;Initial Catalog=Demo_AppDuan;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<UserRole>(userRole =>
			{
				userRole.HasKey(ur => new { ur.UserID, ur.RoleId });

				userRole.HasOne(ur => ur.AppUser)
					.WithMany(u => u.UserRoles)
					.HasForeignKey(ur => ur.UserID)
					.IsRequired();

				userRole.HasOne(ur => ur.Roles)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.RoleId)
					.IsRequired();
			});

			builder.Entity<RolePermission>(rolePermission =>
			{
				rolePermission.HasKey(rp => new { rp.RoleId, rp.PermissionID });

				rolePermission.HasOne(rp => rp.Roles)
					.WithMany(r => r.RolePermissions)
					.HasForeignKey(rp => rp.RoleId)
					.IsRequired();

				rolePermission.HasOne(rp => rp.Permissions)
					.WithMany(p => p.RolePermissions)
					.HasForeignKey(rp => rp.PermissionID)
					.IsRequired();
			});
		}
		}
}
