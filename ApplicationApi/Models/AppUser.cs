using Microsoft.AspNetCore.Identity;

namespace ApplicationApi.Models
{
	public class AppUser : IdentityUser
	{
		public ICollection<UserRole> UserRoles { get; set; }
	}
}
