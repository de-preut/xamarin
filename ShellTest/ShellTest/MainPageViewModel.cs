using System.Windows.Input;
using Xamarin.Forms;

namespace ShellTest
{
    public class MainPageViewModel
    {
        public ICommand GoToPage3Command { get; set; }
        public MainPageViewModel()
        {
            GoToPage3Command = new Command(async () => await Shell.Current.GoToAsync($"{Shell.Current.CurrentState.Location.OriginalString}/Page3"));
        }
    }
}