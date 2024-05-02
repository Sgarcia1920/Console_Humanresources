using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Humanresources
{
	internal class Employee
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string paternal_surname;

		public string Paternal_surname
		{
			get { return paternal_surname; }
			set { paternal_surname = value; }
		}

		private string mother_surname;

		public string Mother_surname
		{
			get { return mother_surname; }
			set { mother_surname = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		private int number_of_children;
		public int Number_of_children
		{
			get { return number_of_children; }
			set { number_of_children = value; }
		}
		public Employee()
		{
			this.name = "";
			this.paternal_surname = "";
			this.mother_surname = "";
			this.age = 0;
			this.number_of_children = 0;
		}
		public Employee(string name, string paternalsurname, string mothersurname, int age, int numberch)
		{
			this.name = name;
			this.paternal_surname = paternalsurname;
			this.mother_surname = mothersurname;
			this.age = age;
			this.number_of_children = numberch;
		}

		public override string ToString()
		{
			return name + " " + paternal_surname + " " + mother_surname + " " + age + " " + number_of_children;
		}

	}
}
