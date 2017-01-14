using System;
using System.ComponentModel.DataAnnotations;

namespace Stella.Domain
{
	public class Planet : EntityAuditBase
	{
		[StringLength(50, ErrorMessage = "*", MinimumLength = 3)]
		[Required]
		public string Name { get; set; }

		[Required]
		public string PicturePath { get; set; }

		public decimal? DistanceFromTheSun { get; set; }
		public string Mass { get; set; }
		public long? Radius { get; set; }

		public long? Diameter
		{
			get { return (Radius == null) ? null : Radius * 2; }
		} 

		public Planet()
		{

		}

		public Planet(int id, string name, string picturePath, long? radius = null, string mass = null, decimal? distanceFromTheSun = null)
		{
			Id = id;
			Name = name;
			PicturePath = picturePath;
			DistanceFromTheSun = distanceFromTheSun;
			Mass = mass;
			Radius = radius;
		}
	}
}
