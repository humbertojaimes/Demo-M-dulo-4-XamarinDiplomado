using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace FormsAssistControl
{
	public class StudentDirectoryService
	{
		public static StudentDirectory LoadStudentDirectory()
		{


			ObservableCollection<Student> students = new ObservableCollection<Student>();
			StudentDirectory studentDirectory = new StudentDirectory();


			students = new ObservableCollection<Student>();

			string[] names = { "José Luis", "Miguel Ángel", "José Francisco", "Jesús Antonio",
								"Sofía", "Camila", "Valentina", "Isabella", "Ximena"};
			string[] lastNames = { "Hernández", "García", "Martínez", "López", "González" };

			Random rdn = new Random(DateTime.Now.Millisecond);

			students = new ObservableCollection<Student>();

			for (int i = 0; i < 20; i++)
			{
				Student student = new Student();
				student.Name = names[rdn.Next(0, 8)];
				student.LastName = $"{lastNames[rdn.Next(0, 5)]} {lastNames[rdn.Next(0, 5)]}";
				string group = rdn.Next(456, 458).ToString();
				student.Group = group;
				student.StudentNumber = rdn.Next(12384748, 32384748).ToString();
				student.Average = rdn.Next(100, 1000) / 10;

				students.Add(student);

			}
			studentDirectory.Students = students;
			return studentDirectory;
		}
	}
}
