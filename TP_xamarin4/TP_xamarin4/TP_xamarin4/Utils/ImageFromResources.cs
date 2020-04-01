using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP_xamarin4.Utils
{
    [ContentProperty(nameof(Source))]
    public class ImageFromResources : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }

            // Do your translation lookup here, using whatever method you require
            var imageSource = ImageSource.FromResource(Source, typeof(ImageFromResources).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}