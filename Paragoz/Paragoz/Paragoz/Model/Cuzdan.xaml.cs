using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paragoz.Model
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cuzdan : ContentPage
	{
		public Cuzdan ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<string> kdkd = new List<string>();
            lblsonuc.Text = cuzdanAdi.Text + " " + miktar.Text;
            cuzdanAdi.Text = null;
            miktar.Text = null;
            DisplayAlert("Cuzdan Kayıt", "başarıyla tamamlandı!", "tamam");
        }
    }
}