using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1_Csharp
{
	public class AnimalManager
	{
		public List<Animal> m_animalList;

		public AnimalManager() //Class constructor
		{
			// In this list objects of diffrent animals of all species are saved.
			m_animalList = new List<Animal>();
		}


		public List<string> GetAnimalInfoList() // Method declaration
		{
			var infolist = new List<string>(); // Create infoList.

			foreach (var animal in m_animalList)
			{
				string info = animal.ToString();
				infolist.Add(info);
			}

			return infolist;
		}

		// method for number of animals.
		public int NbrOfAnimals()
		{
			if (m_animalList is null) return -1;
			return m_animalList.Count();
		}

		public void AddAnimal(Animal animal)
		{

			m_animalList.Add(animal);
			//return true;
		}
	}
}
