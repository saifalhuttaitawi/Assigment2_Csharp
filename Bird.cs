using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Bird : Animal
	{
		string CurrentClass = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name.ToString(); // convert class name to string.
		public Bird(GenderType gender, string name, int age, int wingLength) : base(gender,name, age)
		{
			this.WingLength = wingLength;
		}

		public BirdSpecies Species { get; set; }
		public int WingLength { get; set; }

		public override string ToString()
		{
			return Name+ "     "+ Age.ToString()+"     " + Gender.ToString() +"    "+ 
				CurrentClass+ "      "+Species.ToString()+"      Wing Length :    "+WingLength.ToString();
		}
	}
}
