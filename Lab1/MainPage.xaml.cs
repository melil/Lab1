using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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

        double counter = 0;

        public MainPage()
        {
            this.InitializeComponent();


        }

        private void ell_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            trans.TranslateX += e.Delta.Translation.X;
            trans.TranslateY += e.Delta.Translation.Y;

            if (trans.TranslateX >= 250 && trans.TranslateY <= 350)
            {
                counter++;
            }
            
    
            

            string transX = Convert.ToString(trans.TranslateX);
            string transY = Convert.ToString(trans.TranslateY);
            
            string coord = "x = " + transX + " " + "y = " + transY + "counter: " + counter;
            textblock_lbl.Text = coord;

            
        }

        private void bird_1(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            birdOneTransform.TranslateX += e.Delta.Translation.X;
            birdOneTransform.TranslateY += e.Delta.Translation.Y;



            if(birdOneTransform.TranslateX >= 350)
            {

            }




        }
    }
}
