namespace ApplicationApi.Models
{
	public class UserRole
	{
		public string UserID { get; set; }
		public AppUser AppUser { get; set; }
		public string RoleId { get; set; }
		public Roles Roles { get; set; }
	}
}
