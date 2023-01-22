using System.ComponentModel;
using Xamarin.Forms;
using DemoListView.ViewModels;

namespace DemoListView.Views
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
