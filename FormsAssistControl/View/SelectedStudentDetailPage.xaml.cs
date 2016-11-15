using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsAssistControl
{
	public partial class SelectedStudentDetailPage : ContentPage
	{

		public Student SelectedStudent
		{
			get;
			set;
		}

		public SelectedStudentDetailPage(Student selectedStudent)
		{
			InitializeComponent();
			SelectedStudent = selectedStudent;
			this.BindingContext = SelectedStudent;
		}
	}
}
