using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Duck : Bird
	{
		public Duck(GenderType gender, string name, int age, int wingLength) : base(gender,name, age, wingLength)
		{
			base.Species = BirdSpecies.Duck;
		}
	}
}
