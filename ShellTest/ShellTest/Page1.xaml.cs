using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellTest
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel();
        }

    }
}
