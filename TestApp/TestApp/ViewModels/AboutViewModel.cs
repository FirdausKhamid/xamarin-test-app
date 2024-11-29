using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => {
                Console.WriteLine("Hello World");
                await Browser.OpenAsync("https://google.com"); });
        }

        public ICommand OpenWebCommand { get; }
    }
}
