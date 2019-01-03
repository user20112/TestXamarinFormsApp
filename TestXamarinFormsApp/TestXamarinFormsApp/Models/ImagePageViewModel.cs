using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarinFormsApp.Models
{
    public class ImagePageViewModel
    {
        public ImageModel Image { get; set; }
        public ImagePageViewModel(ImageModel image)
        {
            Image = image;
        }
    }

}
