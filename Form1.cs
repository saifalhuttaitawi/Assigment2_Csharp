using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1_Csharp
{
	public partial class Form1 : Form
	{
		AnimalManager am = new AnimalManager();

		public Form1()
		{
			InitializeComponent();

			// ***********************************************
			//An array to insert enum values to both Listboxes (Gender and Cateogry).
			Array GenderValue = typeof(GenderType).GetEnumValues();
			foreach (object obj in GenderValue)
			{
				GenderLbx.Items.Add(obj);
			}

			Array CategoryValue = typeof(AnimalCategory).GetEnumValues();
			foreach (object obj2 in CategoryValue)
			{
				CategoryLbx.Items.Add(obj2);
			}
		}


		private void button1_Click(object sender, EventArgs e)
		{
		//	int.TryParse(AgeTbx.Text, out int age);         //	convert Agebox Context to int, and name it age.


				if (string.IsNullOrEmpty(NameTbx.Text))
			{
			MessageBox.Show("Name should not be empty!, Please write the name of your animal",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error // for Warning  
								   //MessageBoxIcon.Error // for Error 
								   //MessageBoxIcon.Information  // for Information
								   //MessageBoxIcon.Question // for Question
			);
			}

			else if (string.IsNullOrEmpty(AgeTbx.Text))
			{
				MessageBox.Show("Age should not be empty!, Please write the Age of your animal",
				"Wrong input!",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error // for Warning  
									 //MessageBoxIcon.Error // for Error 
									 //MessageBoxIcon.Information  // for Information
									 //MessageBoxIcon.Question // for Question
				);
			}

			else if (GenderLbx.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a gender for your animal",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error // for Warning  
								 //MessageBoxIcon.Error // for Error 
								 //MessageBoxIcon.Information  // for Information
								 //MessageBoxIcon.Question // for Question
			);
			}

			else if (CategoryLbx.SelectedIndex < 0)
			{
				MessageBox.Show("Please select an animal category for your animal",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error // for Warning  
								 //MessageBoxIcon.Error // for Error 
								 //MessageBoxIcon.Information  // for Information
								 //MessageBoxIcon.Question // for Question
			);
			}

			else if (AnimalLbx.SelectedIndex < 0)
			{
				MessageBox.Show("Please select an Animal",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error // for Warning  
								 //MessageBoxIcon.Error // for Error 
								 //MessageBoxIcon.Information  // for Information
								 //MessageBoxIcon.Question // for Question
			);
			}
			// (string.IsNullOrEmpty(AgeTbx.Text))
			//if (title == "User greeting" || title == "User name") { do stuff};
			
			else if (string.IsNullOrEmpty(SpcTbx.Text))
			{
				MessageBox.Show("Please select an Animal Specification",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Error // for Warning  
								 //MessageBoxIcon.Error // for Error 
								 //MessageBoxIcon.Information  // for Information
								 //MessageBoxIcon.Question // for Question
			);
			}
			else if (!int.TryParse(AgeTbx.Text, out int age))	// 
			{
				MessageBox.Show("Age should contain only numbers",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Warning // for Warning  
								   //MessageBoxIcon.Error // for Error 
								   //MessageBoxIcon.Information  // for Information
								   //MessageBoxIcon.Question // for Question
			);
			}
			else if (!int.TryParse(SpcTbx.Text, out int isNumber2))
			{
				MessageBox.Show("Animal Specification should contain only numbers",
			"Wrong input!",
			MessageBoxButtons.OK,
			MessageBoxIcon.Warning // for Warning  
								   //MessageBoxIcon.Error // for Error 
								   //MessageBoxIcon.Information  // for Information
								   //MessageBoxIcon.Question // for Question
			);
			}

			else
				{
				//int.TryParse(AgeTbx.Text, out int age);         //	convert Agebox Context to int, and name it age.
				string nameOfAnimal = this.NameTbx.Text;        //	convert Namebox context to string and name it nameOfAnimal;

				GenderType gender = (GenderType)this.GenderLbx.SelectedIndex;


				int id = this.CategoryLbx.SelectedIndex;        //	choose the classes under the selected index in category list box.
				switch (id)
				{
					case (int)AnimalCategory.Mammal:            //	when mammal 

						int.TryParse(SpcTbx.Text, out int teeth);   // convert T1 Context to int, and name it teeth.
						MammalSpecies species = (MammalSpecies)AnimalLbx.SelectedIndex; //we cast the index of animal list box to mammel species.

						Mammal mammal = MammalFactory.CreateMammal(species, gender, nameOfAnimal, age, teeth);  //Create obj Mammal

						am.AddAnimal(mammal);   //Add Animal mammal to our list(Animal Manager).


						break;


					case (int)AnimalCategory.Bird:              //when bird
						int.TryParse(SpcTbx.Text, out int wing);    //	convert T2 Context to int, and name it wing.

						BirdSpecies species2 = (BirdSpecies)this.AnimalLbx.SelectedIndex;   //we cast the index of animal list box to bird species.

						Bird bird = BirdFactory.CreateBird(species2, gender, nameOfAnimal, age, wing);  //Create obj Bird
						am.AddAnimal(bird);


						break;


				}

				UpdateListbox();

			}
		}

		private void UpdateListbox()
		{
			listBox1.Items.Clear();
			var infoList = am.GetAnimalInfoList();

			for (int i = 0; i < infoList.Count; i++)
			{
				listBox1.Items.Add(infoList.ElementAt(i));
			}
		}





		private void label6_Click(object sender, EventArgs e)
		{

		}


		private void CategoryLbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			AnimalLbx.Items.Clear();
			groupBox3.Controls.Clear();

			Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Assigment1_Csharp");

			int id = this.CategoryLbx.SelectedIndex;        // choose the classes under the selected index in category list box.

			switch (id)
			{
				case (int)AnimalCategory.Mammal:       // choosing Mammal in category list box
					for (int i = 0; i < Enum.GetNames(typeof(MammalSpecies)).Length; i++)         // showes the items under bird class in Animal list box.
					{
						AnimalLbx.Items.Add((MammalSpecies)i);
						//if (type.IsSubclassOf(typeof(Mammal))) this.AnimalLbx.Items.Add(type.ToString().Replace("Assigment1_Csharp.", ""));
					}
					groupBox3.Text = "Mammal Specifications";
					L1.Text = "The amount of teeth:";
					groupBox3.Controls.Add(SpcTbx);
					SpcTbx.Visible = true;
					groupBox3.Controls.Add(L1);

					break;

				case (int)AnimalCategory.Bird:         // choosing bird in category list box.
					for (int i = 0; i < Enum.GetNames(typeof(BirdSpecies)).Length; i++)         // showes the items under bird class in Animal list box.
					{
						AnimalLbx.Items.Add((BirdSpecies)i);
						//if (type.IsSubclassOf(typeof(Bird))) this.AnimalLbx.Items.Add(type.ToString().Replace("Assigment1_Csharp.", ""));
					}
					groupBox3.Text = "Bird Specifications";
					L2.Text = "Wing Length:";
					groupBox3.Controls.Add(SpcTbx);
					SpcTbx.Visible = true;
					groupBox3.Controls.Add(L2);
					break;

			}
		}

		public Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
		{
			return
				assembly.GetTypes()
						.Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
						.ToArray();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
