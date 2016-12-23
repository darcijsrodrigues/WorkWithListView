using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WorkWithListView.Views
{
	public partial class WorkWithListView_Simple : ContentPage
	{
		public WorkWithListView_Simple()
		{
			InitializeComponent();

			string[] contacts = new string[] {
				"Beatriz",
				"Laura",
				"Júlia",
				"Maria",
				"Sofia",
				"Isabela",
				"Larissa",
				"Maria Eduarda",
				"Camila"
			};

			lstContacts.ItemsSource = contacts;
		}
	}
}
