using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Oddballs
{
    public partial class CreateAccount : ContentPage
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

    

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Account Created", "Account Done", "OK");
        }
    }
}
