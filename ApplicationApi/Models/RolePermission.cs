namespace ApplicationApi.Models
{
	public class RolePermission
	{
		public string RoleId { get; set; }
		public Roles Roles { get; set; }
		public string PermissionID { get; set; }
		public Permissions Permissions { get; set; }
	}
}
