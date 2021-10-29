using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("Page3", typeof(Page3));
        }
    }
}
