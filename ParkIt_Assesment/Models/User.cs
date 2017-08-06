using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkIt_Assesment.Models
{
	public class User
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string ForeName { get; set; }
		[Required]
		public string SurName { get; set; }
		public DateTime Created { get; set; }
	}
}