

using Console_Humanresources;
public class Program
{

	static void Main(string[] args)
	{
		int employeeCount = 0;
		int option;
		Employee[] employees = new Employee[20];


		do
		{
			Console.WriteLine("HUMAN RESOURCES");
			Console.WriteLine("Choose an option \n1)enter information\n2)save file\n3)exitS");
			option = int.Parse(Console.ReadLine());
			switch (option)
			{
				case 1:

					while (true)
					{
						if (employeeCount >= employees.Length)
						{
							Console.WriteLine("You have already entered information for all employees.");
							break;
						}

						Console.WriteLine("Enter the name for employee");
						string name = Console.ReadLine();
						Console.WriteLine("Enter the paternal surname for employee");
						string paternalSurname = Console.ReadLine();
						Console.WriteLine("Enter the mother surname for employee");
						string motherSurname = Console.ReadLine();
						Console.WriteLine("Enter the age for employee");
						int age = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter the number of children for employee");
						int numberOfChildren = int.Parse(Console.ReadLine());

						employees[employeeCount] = new Employee
						{
							Name = name,
							Paternal_surname = paternalSurname,
							Mother_surname = motherSurname,
							Age = age,
							Number_of_children = numberOfChildren
						};
						employeeCount++;

						Console.WriteLine("Do you wish to enter information for another employee? (y/n)");
						string response = Console.ReadLine().ToLower();
						if (response != "y")
						{
							break;
						}
					}
					break;

				case 2:
					
					string path = @"C:\Users\Ani uwu\Documents\Files";
					using (StreamWriter sw = File.CreateText(path))
					{
						sw.WriteLine("Name,Paternal surname,Mother surname,Age,Number of children");
						for (int i = 0; i < employeeCount; i++)
						{
							sw.WriteLine($"{employees[i].Name},{employees[i].Paternal_surname},{employees[i].Mother_surname},{employees[i].Age},{employees[i].Number_of_children}");
						}
					}
					Console.WriteLine("File saved successfully");
					break;
				default:
					Console.WriteLine("Nothing");
					break;
			}

		} while (option != 3);

	}
}
