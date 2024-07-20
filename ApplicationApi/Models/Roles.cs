using Microsoft.AspNetCore.Identity;

namespace ApplicationApi.Models
{
	public class Roles : IdentityRole
	{
		public ICollection<UserRole> UserRoles { get; set; }
		public ICollection<RolePermission> RolePermissions { get; set; }
	}
}
