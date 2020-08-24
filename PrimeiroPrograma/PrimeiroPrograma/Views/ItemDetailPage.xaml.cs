using System.ComponentModel;
using Xamarin.Forms;
using PrimeiroPrograma.ViewModels;

namespace PrimeiroPrograma.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}