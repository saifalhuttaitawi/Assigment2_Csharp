﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class Cat : Mammal
	{

		public Cat(GenderType gender,string name, int age,int teethAmount) : base(gender, name, age, teethAmount)
		{
			base.Species = MammalSpecies.Cat;
		}
	}
}
