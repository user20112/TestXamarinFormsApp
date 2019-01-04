using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace TestXamarinFormsApp 
{
    class MainPageViewModel : INotifyPropertyChanged
    {
       public ObservableCollection<ImageModel> ListViewSource { get; set; }

        
       public MainPageViewModel()
        {
            ListViewSource = new ObservableCollection<ImageModel>();
            ListViewSource.Add(new ImageModel("Apple", "apple.jpg", "This is an apple"));
            ListViewSource.Add(new ImageModel("Melon", "melon.jpg", "This is a watermelon"));
            ListViewSource.Add(new ImageModel("Pomegranate", "pomegranate.jpg", "This is a pomegranate"));
            ListViewSource.Add(new ImageModel("Strawberry", "strawberry.jpg", "This is a strawberry"));
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                ((INotifyPropertyChanged)ListViewSource).PropertyChanged += value;
            }

            remove
            {
                ((INotifyPropertyChanged)ListViewSource).PropertyChanged -= value;
            }
        }
    }
}
