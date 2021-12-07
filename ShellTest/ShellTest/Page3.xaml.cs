using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellTest
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Shell.Current.Navigation.PopModalAsync();
        }
    }
}
