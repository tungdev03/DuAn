namespace ApplicationApi.Models
{
	public class Permissions
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<RolePermission> RolePermissions { get; set; }
	}
}
