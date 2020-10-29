using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Oddballs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Sign In", "Success","Ok");

        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Create Account", "Success", "Ok");

          Navigation.PushAsync(new CreateAccount());

        }
    }
}
