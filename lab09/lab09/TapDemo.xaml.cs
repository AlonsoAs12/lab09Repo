﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        public TapDemo()
        {
            InitializeComponent();

            var image = new Image
            {

                Source = "tapoed.jpeg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += onTapGestureRecognizerTapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            label = new Label
            {

                Text = "tap the photo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,

            };

            Content = new StackLayout
            {

                Padding = new Thickness(20, 100),

                Children =
                {

                    image,
                    label

                }

            };

            void onTapGestureRecognizerTapped(object sender, EventArgs args)
            {

                tapCount++;
                label.Text = String.Format("{0} tap{1} so far!",
                    tapCount,
                    tapCount == 1 ? "" : "s");

                var imageSender = (Image)sender;

                if (tapCount % 2 == 0)
                {

                    imageSender.Source = "tapped.jpeg";

                }
                else
                {

                    imageSender.Source = "tapped_bw.jpeg";

                }

            }

        }
    }
}