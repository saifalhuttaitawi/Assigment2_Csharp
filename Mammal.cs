using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Mammal :  Animal
	{
		string CurrentClass = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name.ToString(); // Convert class to string.
		public Mammal(GenderType gender,string name, int age,  int teethAmount) : base(gender,name, age)
		{
			this.TeethAmount = teethAmount;
		}

		public MammalSpecies Species { get; set; }
		public int TeethAmount { get; set; }

		public override string ToString()
		{
			return Name + "     " + Age.ToString() + "     " + Gender.ToString() + "    " + CurrentClass +
				 "      " + Species.ToString() + "     Teeth Amount     " + TeethAmount.ToString();
		}
	}

}
