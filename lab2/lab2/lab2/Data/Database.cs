using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using lab2.Models;

namespace lab2.Data
{
	public class Database: DbContext
	{
		public Database() : base("DatabaseContext")
        {
		}

		public DbSet<User> Users { get; set; }


	}
}