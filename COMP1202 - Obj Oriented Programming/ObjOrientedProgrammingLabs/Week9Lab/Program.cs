namespace Week9Lab
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();
			person1.Name = "Monkey D. Luffy";
			person1.Age = 19;

			Person person2 = new Person("Roronoa Zoro", 21);
			Person person3 = new Person("Nami", 20);
			Person person4 = new Person("Usopp", 19);
			Person person5 = new Person("Sanji", 21);
			Person person6 = new Person("Tony Tony Chopper", 17);
			Person person7 = new Person("Robin", 30);
			Person person8 = new Person("Franky", 36);
			Person person9 = new Person("Brook", 90);
			Person person10 = new Person("Jinbei", 46);

			Team team = new Team("Straw Hat Pirates");
			team.SetCaptain(person1);
			team.AddTeamMember(person2);
			team.AddTeamMember(person3);
			team.AddTeamMember(person4);
			team.AddTeamMember(person5);
			team.AddTeamMember(person6);
			team.AddTeamMember(person7);
			team.AddTeamMember(person8);
			team.AddTeamMember(person9);
			team.AddTeamMember(person10);

			Console.WriteLine("----------------------------------------");
			Console.WriteLine(person1);
			Console.WriteLine(person2);
			Console.WriteLine(person3);
			Console.WriteLine(person4);
			Console.WriteLine(person5);
			Console.WriteLine(person6);		
			Console.WriteLine(person7);
			Console.WriteLine(person8);
			Console.WriteLine(person9);
			Console.WriteLine(person10);
			Console.WriteLine("----------------------------------------");
			Console.WriteLine(team);
			Console.WriteLine("----------------------------------------");
			team.RemoveCaptain();
			Console.WriteLine(team);
			Console.WriteLine("----------------------------------------");
		}
	}
}
