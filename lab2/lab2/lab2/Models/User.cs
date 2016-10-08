using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
	public class User
	{
		public int ID { get; set; }


		[Required]
		[Display(Name = "First Name")]
		public String firstName { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		public String lastName { get; set; }

		[Required]
		[Display(Name = "Email Address")]
		public String email { get; set; }

		[Required]
		[Display(Name = "Alignment")]
		public String alignment { get; set; }
	}
}