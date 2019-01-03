using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXamarinFormsApp
{
    public class ImageModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


        public ImageModel(string title, string image, string description)
        {
            Title = title;
            Image = image;
            Description = description;
        }
    }

}
