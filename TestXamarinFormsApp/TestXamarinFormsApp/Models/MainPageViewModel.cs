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
