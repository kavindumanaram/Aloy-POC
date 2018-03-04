using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudOperationCodeFirdt.Models.NHL
{
	public class Team
	{
		/// <summary>
		/// get and set for team name.
		/// </summary>
		[Key]
		[MaxLength(30)]
		public string TeamName { get; set; }

		/// <summary>
		/// get and set for city.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// get and set for provice.
		/// </summary>
		public string Province { get; set; }

		/// <summary>
		/// get and set for player.
		/// </summary>
		public List<Player> Players { get; set; }
	}
}