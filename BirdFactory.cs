using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public static class BirdFactory
	{
		public static Bird CreateBird(BirdSpecies category, GenderType gender, string name, int age, int wingLength)
		{
			switch (category)
			{
				case BirdSpecies.Eagle:
					Eagle eggy = new Eagle(gender, name, age, wingLength);
					return eggy;

				case BirdSpecies.Duck:
					Duck ducky = new Duck(gender, name, age, wingLength);
					return ducky;

				default:
					return null;
			}
		}
	}
}
