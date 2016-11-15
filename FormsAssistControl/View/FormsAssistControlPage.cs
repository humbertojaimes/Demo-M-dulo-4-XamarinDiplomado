using System;

using Xamarin.Forms;

namespace FormsAssistControl
{
	public class FormsAssistControlPage : ContentPage
	{
		public FormsAssistControlPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

