using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using CrudOperationCodeFirdt.Models.NHL;

namespace CrudOperationCodeFirdt.Data
{
	public class NhlContext: DbContext
	{
		/// <summary>
		/// constructoer : db connection
		/// </summary>
		public NhlContext() : base("DefaultConnection")
		{	}

		public DbSet<Team> Teams { get; set; }

		public DbSet<Player> Players { get; set; }
	}
}