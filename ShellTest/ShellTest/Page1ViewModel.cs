using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShellTest
{
    public class Page1ViewModel
    {
        public ICommand GoToMainPageCommand { get; set; }
        public Page1ViewModel()
        {
            GoToMainPageCommand = new Command(async () => await Shell.Current.GoToAsync($"{Shell.Current.CurrentState.Location.OriginalString}/MainPage"));
        }
    }
}
