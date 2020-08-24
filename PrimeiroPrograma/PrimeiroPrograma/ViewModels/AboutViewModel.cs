using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PrimeiroPrograma.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(ExecutarComando);
            /*async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart")*/
        }

        public ICommand OpenWebCommand { get; }

        private void ExecutarComando(object obj)
        {
            var duracao = TimeSpan.FromSeconds(10);
            Vibration.Vibrate(duracao);
            Browser.OpenAsync("https://aka.ms/xamain-quickstart");
        }
    }
}