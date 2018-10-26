using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Eagle : Bird
	{
		public Eagle(GenderType gender,string name, int age, int wingLength) : base(gender,name, age,wingLength)
		{
			base.Species = BirdSpecies.Eagle;
		}


	}
}
