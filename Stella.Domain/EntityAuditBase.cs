using System;

namespace Stella.Domain
{
	public class EntityAuditBase
	{
		public int Id { get; set; }
		public DateTime Created { get; set; }
		public DateTime? Modified { get; set; }

		public EntityAuditBase()
		{
			Created = DateTime.Now;
		}
	}
}