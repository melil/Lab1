using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ell_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            trans.TranslateX += e.Delta.Translation.X;
            trans.TranslateY += e.Delta.Translation.Y;

            if (trans.TranslateX > 500)
            {
                trans.TranslateX = 500; 
            } else if (trans.TranslateX < 0)
            {
                trans.TranslateX = 0;
            } 


            if (trans.TranslateY > 500)
            {
                trans.TranslateY = 500;
            } else if (trans.TranslateY < 0)
            {
                trans.TranslateY = 0;
            }

            string transX = Convert.ToString(trans.TranslateX);
            string transY = Convert.ToString(trans.TranslateY);
            string coord = "x = " + transX + " " + "y = " + transY;
            textblock_lbl.Text = coord;

            
        }
        
       
    }
}
