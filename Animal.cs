using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Animal
	{


		//private string mName;
		//private int mAge;
		//private int mID;

		public Animal(GenderType gender, string name, int age)
		{
			Name = name;
			Age = age;
			Gender = gender;
			
		}

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;

		}

		public GenderType Gender { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		


	}


}
