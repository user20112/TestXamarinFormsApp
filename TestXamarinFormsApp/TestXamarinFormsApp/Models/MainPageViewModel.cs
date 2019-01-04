using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TestXamarinFormsApp
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ImageModel> _ListViewSource;
        public ObservableCollection<ImageModel> ListViewSource
        {
            get
            {
                return _ListViewSource;
            }
            set
            {
                _ListViewSource = value;
                OnPropertyChanged(nameof(ListViewSource));
            }
        }
        public MainPageViewModel()
        {
            ListViewSource = new ObservableCollection<ImageModel>();
            ListViewSource.Add(new ImageModel("Apple", "apple.jpg", "This is an apple"));
            ListViewSource.Add(new ImageModel("Melon", "melon.jpg", "This is a watermelon"));
            ListViewSource.Add(new ImageModel("Pomegranate", "pomegranate.jpg", "This is a pomegranate"));
            ListViewSource.Add(new ImageModel("Strawberry", "strawberry.jpg", "This is a strawberry"));
        }
        public void Add(ImageModel Image)
        {
            ListViewSource.Add(Image);
            OnPropertyChanged(nameof(ListViewSource));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
