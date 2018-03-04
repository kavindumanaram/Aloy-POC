using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudOperationCodeFirdt.Models.NHL
{
	public class Player
	{
		/// <summary>
		/// get and set for jersy number.
		/// </summary>
		[Key, Column(Order = 0)]
		public int PlayerId { get; set; }

		/// <summary>
		/// get and set for first name.
		/// </summary>
		[Key, Column(Order = 1)]
		public string Firstname { get; set; }
		
		/// <summary>
		/// get and set for last name.
		/// </summary>
		[Key, Column(Order = 2)]
		public string Lastname { get; set; }

		/// <summary>
		/// get and set for position.
		/// </summary>
		public string Position { get; set; }

		public string TeamName { get; set; }
		public Team Team { get; set; }

	}
}