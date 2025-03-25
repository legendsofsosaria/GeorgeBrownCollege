using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week9Lab
{
	internal class Team
	{
		private static int teamCount;
		private int teamID;
		private string? teamName;
		private string? captain;
		private List<Person> teamMembers;

		public int TeamID { get { return teamID; } set { teamID = value; } }
		public string? TeamName { get { return teamName; } set { teamName = value; } }
		public string? Captain { get { return captain; } set { captain = value; } }

		public Team() 
		{ 
			teamMembers = new List<Person>();
		}
		
		public Team(string teamName)
		{
			TeamName = teamName ?? "No team name!";
			teamMembers = new List<Person>();
		}

		public void SetCaptain(Person captain)
		{
			this.captain = captain.ToString();
			teamCount++;
		}

		public void AddTeamMember(Person person)
		{
			teamMembers.Add(person);
			teamCount++;
		}

		public void RemoveCaptain()
		{
			Captain = "No Captain!";
		}

		public override string ToString()
		{
			return $"Team ID: {TeamID}, Team Name: {TeamName}, Team Captain: {Captain}, Number of Members: {teamCount}";
		}
	}
}
