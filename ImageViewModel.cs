using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXamarinFormsApp
{
    class ImageViewModel
    {
        public string Title { get; set; }
        public Image ActualImage { get; set; }
        public Image Imperfections { get; set; }
        public string Description { get; set; }


        public ImageViewModel(string title, Image actualImage, Image imperfections,string description)
        {
            Title = title;
            ActualImage = actualImage;
            Imperfections = imperfections;
            Description = description;
        }
    }
    
}
