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
	public partial class Giris : ContentPage
	{
		public Giris ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "admin" && password.Text=="1234")
            {
                DisplayAlert("Giriş", "Giriş Başarılı", "Tamam");
            }
            else
            {
                DisplayAlert("Giriş Hatası", "Giriş Başarısız", "Tamam");

            }
        }
    }
}