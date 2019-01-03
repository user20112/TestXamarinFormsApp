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
            MainPageViewModel MainPageData = new MainPageViewModel();
            MainPageData.ListViewSource.Add(new ImageModel("Apple", "apple.jpg", "This is an apple"));
            MainPageData.ListViewSource.Add(new ImageModel("Melon", "melon.jpg", "This is a watermelon"));
            MainPageData.ListViewSource.Add(new ImageModel("Pomegranate", "pomegranate.jpg", "This is a pomegranate"));
            MainPageData.ListViewSource.Add(new ImageModel("Strawberry", "strawberry.jpg", "This is a strawberry"));
            BindingContext = MainPageData;

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
