using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public static class MammalFactory 
	{
		static public Mammal CreateMammal(MammalSpecies species, GenderType gender,string name, int age, int teethAmount) {
			switch (species)
			{
				case (MammalSpecies.Dog):
					Dog doggy = new Dog(gender, name , age, teethAmount);
					return doggy;
					
				case (MammalSpecies.Cat):
					Cat catty = new Cat(gender, name , age , teethAmount);
					return catty;
				default: return null;
			}
		}


	}
}
