using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TestXamarinFormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            ObservableCollection<ImageViewModel> ListViewSource = new ObservableCollection<ImageViewModel>();
            InitializeComponent();
            DisplayListView.ItemsSource = ListViewSource;
            ImageModel Data = new ImageModel("Image1Label", ImageSource.FromResource("TestXamarinFormsApp.images.image1actual.jpg"), ImageSource.FromResource("TestXamarinFormsApp.images.image1imperfections.gif"), "This Is the Description for image1");
            ListViewSource.Add(new ImageViewModel(Data.Title, Data.ActualImage, Data.Imperfections, Data.Description));


        }

        public void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            StackLayout content = new StackLayout();
            ImageViewModel selected = (ImageViewModel)DisplayListView.SelectedItem;
            content.Children.Add(new Label { Text = (selected.Title) });
            content.Children.Add(new Label { Text = (selected.Description) });
            content.Children.Add(new ZoomImage { Source = (selected.ActualImage.Source) });
            Navigation.PushAsync(new ContentPage
            {
                Content = content
            });

        }
    }
}
