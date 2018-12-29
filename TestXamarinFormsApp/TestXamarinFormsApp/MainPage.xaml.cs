using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Android.Graphics;

namespace TestXamarinFormsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            ObservableCollection<ImageViewModel> Image1ListViewSource = new ObservableCollection<ImageViewModel>();
            ObservableCollection<ImageViewModel> Image2ListViewSource = new ObservableCollection<ImageViewModel>();
            InitializeComponent();
            Image1ListView.ItemsSource = Image1ListViewSource;
            Image2ListView.ItemsSource = Image2ListViewSource;
            ImageModel Data = new ImageModel("Image1Label", ImageSource.FromResource("TestXamarinFormsApp.images.image1actual.jpg"), ImageSource.FromResource("TestXamarinFormsApp.images.image1imperfections.gif"), "This Is the Description for image1", 10);
            Image1ListViewSource.Add(new ImageViewModel(Data.Title, Data.ActualImage, Data.Imperfections, Data.Description, Data.PassFail));
            Data = new ImageModel("Image2Label", ImageSource.FromResource("TestXamarinFormsApp.images.image2actual.jpg"), ImageSource.FromResource("TestXamarinFormsApp.images.image2imperfections.gif"), "This Is the Description for image2", 10);
            Image2ListViewSource.Add(new ImageViewModel(Data.Title, Data.ActualImage, Data.Imperfections, Data.Description, Data.PassFail));

        }

        public void OnImageTapped(object o, ItemTappedEventArgs e)
        {
            StackLayout content = new StackLayout();
            ImageViewModel selected = (ImageViewModel)((ListView)o).SelectedItem;
            content.Children.Add(new Label { Text = (selected.Title) });
            content.Children.Add(new Label { Text = (selected.Description) });
            content.Children.Add(new ZoomImage { Source = (selected.ActualImage.Source) });
            Navigation.PushAsync(new ContentPage
            {
                Content = content
            });

        }
        public void ResetClick(object o, ItemTappedEventArgs e)
        {


        }
       
    }
}
