using System;
namespace FormsAssistControl
{
	//https://github.com/HumbertoJaimes
	public class Student
	{


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value;  }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value;  }
		}

		private string group;

		public string Group
		{
			get { return group; }
			set { group = value;  }
		}

		private string studentNumber;

		public string StudentNumber
		{
			get { return studentNumber; }
			set { studentNumber = value;  }
		}

		private double average;

		public double Average
		{
			get { return average; }
			set { average = value; }
		}

	}
}
