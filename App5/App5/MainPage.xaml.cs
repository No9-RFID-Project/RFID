﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白頁項目範本已記錄在 http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void U1_Click(object sender, RoutedEventArgs e)
        {
            g1.Visibility = Windows.UI.Xaml.Visibility.Visible;
            g2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            g3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void U2_Click(object sender, RoutedEventArgs e)
        {
            g1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            g2.Visibility = Windows.UI.Xaml.Visibility.Visible;
            g3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void U3_Click(object sender, RoutedEventArgs e)
        {
            g1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            g2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            g3.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }
        //------------------我是U1-------------------------------
        private void G1B1_Click(object sender, RoutedEventArgs e)
        {
            
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/black.png", UriKind.RelativeOrAbsolute)); ;
            

        }
        
        private void G1B2_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/blue.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B3_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/brown.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B4_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/green.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B5_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/orange.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B6_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/purple.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B7_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/red.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B8_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/white.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G1B9_Click(object sender, RoutedEventArgs e)
        {
            I1.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/close/yellow.png", UriKind.RelativeOrAbsolute)); ;
        }


        //------------------------------------我是U2------------------------------------------------------
        private void G2B1_Click(object sender, RoutedEventArgs e)
        {
            //Image myimage_g2b1 = new Image();
               
            //myimage_g2b1.Source=new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/blackp.png", UriKind.RelativeOrAbsolute));
            
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/blackp.png", UriKind.RelativeOrAbsolute)); ;
               
            //I2.Width = 500;
            //I2.Height = 500;
        }

        private void G2B2_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/blackp2.png", UriKind.RelativeOrAbsolute)); ;

        }

        private void G2B3_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/bluep.png", UriKind.RelativeOrAbsolute)); ;

        }

        private void G2B4_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/brownp.png", UriKind.RelativeOrAbsolute)); ;

        }

        private void G2B5_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/greenp.png", UriKind.RelativeOrAbsolute)); ;

        }

        private void G2B6_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/orangep.png", UriKind.RelativeOrAbsolute)); ;

        }

        private void G2B7_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/purplep.png", UriKind.RelativeOrAbsolute)); ;

        }
        private void G2B8_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/redp.png", UriKind.RelativeOrAbsolute)); ;

        }
        private void G2B9_Click(object sender, RoutedEventArgs e)
        {
            I2.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/pant/whitep.png", UriKind.RelativeOrAbsolute)); ;

        }

        //--------------------------------------------------------------------------
        private void G3B1_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/black_shoes.png", UriKind.RelativeOrAbsolute)); ;
            
        }
        private void G3B2_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/blue_shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B3_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/brown_shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B4_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/deepblue_shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B5_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/gray shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B6_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/green shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B7_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/orange shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
        private void G3B8_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/pink shoes.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G3B9_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/purple shoes.png", UriKind.RelativeOrAbsolute)); ;
        }

        private void G3B0_Click(object sender, RoutedEventArgs e)
        {
            I3.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx://" + "/Assets/shoes/red shoes.png", UriKind.RelativeOrAbsolute)); ;
        }
    }
}
