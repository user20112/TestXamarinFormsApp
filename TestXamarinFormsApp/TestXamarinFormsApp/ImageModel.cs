using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXamarinFormsApp
{
    class ImageModel
    {
        public string Title { get; set; }
        public Image ActualImage { get; set; }
        public Image Imperfections { get; set; }
        public string Description { get; set; }


        public ImageModel(string title, ImageSource actualImage, ImageSource imperfections, string description)
        {
            Title = title;
            ActualImage = new Image();
            Imperfections = new Image();
            ActualImage.Source = actualImage;
            Imperfections.Source = imperfections;
            Description = description;
        }
    }

}
