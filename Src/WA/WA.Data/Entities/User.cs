using WA.Data.Base;

namespace WA.Data.Entities
{
    public class User: BaseEntity
    {
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int Role { get; set; }
		public bool Active { get; set; }
	}
}
