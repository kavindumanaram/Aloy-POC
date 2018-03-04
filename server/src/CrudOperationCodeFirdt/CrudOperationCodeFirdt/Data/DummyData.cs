using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudOperationCodeFirdt.Models.NHL;

namespace CrudOperationCodeFirdt.Data
{
	public class DummyData
	{
		public static System.Collections.Generic.List<Team> getTeams()
		{
	 List<Team> teams = new List<Team>()
		{
			new Team()
			{
				TeamName = "Canuckers",
				City = "London",
				Province = "BC",
			},
			new Team()
			{
				TeamName = "Spatecus",
				City = "Colombo",
				Province = "WP",
			}
		};
			return teams;
		}

	private List<Player> getPlayers
	}
}