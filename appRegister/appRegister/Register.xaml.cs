using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appRegister
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
		public Register()
		{
			InitializeComponent();
			btn.Clicked += Btn_Clicked;
		}
		register r = new register();
		private void Btn_Clicked(object sender, EventArgs e)
		{
			if (txtfrst.Text == null || txtlast.Text == null || txtemail.Text == null || txtpsw.Text == null)
			{
				DisplayAlert("Error", "Enter all information ...", "OK");
			}
			else
			{
				r.firstname = txtfrst.Text;
				r.lastname = txtlast.Text;
				r.email = txtemail.Text;
				r.psw = txtpsw.Text;
				DisplayAlert("Message", "All information remplir success ...", "OK");
			}
		}
	}
}