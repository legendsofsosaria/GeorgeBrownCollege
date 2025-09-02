using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
	internal class Address
	{
		private int streetNum;
		private string? streetName;
		private string? city;
		private string? province;
		private string? postalCode;
		private string? country;

		public int StreetNum { get { return streetNum; } set { streetNum = value; } }
		public string? StreetName { get { return streetName; } set { streetName = value; } }
		public string? City { get { return city; } set { city = value; } }
		public string? Province { get { return province; } set { province = value; } }
		public string? PostalCode { get { return postalCode; } set { postalCode = value; } }
		public string? Country { get { return country; } set { country = value; } }	

		public Address() { } // default
		public Address(int streetNum, string? streetName, string? city, string? province, string? postalCode, string? country)
		{
			StreetNum = streetNum;
			StreetName = streetName ?? throw new ArgumentNullException(nameof(streetName));
			City = city ?? throw new ArgumentNullException(nameof(city));
			Province = province ?? throw new ArgumentNullException(nameof(province));
			PostalCode = postalCode ?? throw new ArgumentNullException(nameof(postalCode));
			Country = country ?? throw new ArgumentNullException(nameof(country));
		}

		public override string ToString()
		{
			return $"Address: {StreetNum} {StreetName}, {City}, {PostalCode}, {Country}";
		}
	}
}
