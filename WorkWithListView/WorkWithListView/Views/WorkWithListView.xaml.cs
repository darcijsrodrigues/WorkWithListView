using System;
using System.Collections.Generic;
using WorkWithListView.Model;

using Xamarin.Forms;

namespace WorkWithListView.Views
{
	public partial class WorkWithListView : ContentPage
	{
		public WorkWithListView()
		{
			InitializeComponent();

			lstContacts.ItemsSource = getListContacts();
		}

		List<Contact> getListContacts() { 
			return new List<Contact>{
				new Contact(){name="Beatriz",phone="+55 (31) 1111-1111", urlImage="icon.png"},
				new Contact(){name="Laura",phone="+55 (31) 2222-2222", urlImage="icon.png"},
				new Contact(){name="Júlia",phone="+55 (31) 3333-3333", urlImage="icon.png"},
				new Contact(){name="Maria",phone="+55 (31) 5555-5555", urlImage="icon.png"},
				new Contact(){name="Sofia",phone="+55 (31) 6666-6666", urlImage="icon.png"},
				new Contact(){name="Isabela",phone="+55 (31) 7777-7777", urlImage="icon.png"},
				new Contact(){name="Larissa",phone="+55 (31) 8888-8888", urlImage="icon.png"},
				new Contact(){name="Maria Eduarda",phone="+55 (31) 9999-9999", urlImage="icon.png"},
				new Contact(){name="Camila",phone="+55 (31) 0000-0000", urlImage="icon.png"}
			};
		}
	}
}
