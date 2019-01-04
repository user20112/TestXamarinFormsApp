using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXamarinFormsApp.Models;
using Xamarin.Forms;


namespace TestXamarinFormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            BindingContext = new MainPageViewModel();

        }

        public void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            
            
            Navigation.PushAsync(new ImagePage
            {
                BindingContext = new ImagePageViewModel((ImageModel)((ListView)o).SelectedItem)
            });

        }
    }
}
