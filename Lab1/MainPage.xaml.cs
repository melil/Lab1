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
        bool bool1, bool2, bool3, bool4, bool5, bool6, bool7, bool8, bool9 = false;

        public MainPage()
        {
            this.InitializeComponent();
            calculate();


        }

        private void imgOne_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgOneTransform.TranslateX += e.Delta.Translation.X;
            imgOneTransform.TranslateY += e.Delta.Translation.Y;

            if (imgOneTransform.TranslateX >= 24 && imgOneTransform.TranslateX <= 47)
            {
                    if (imgOneTransform.TranslateY >= 174 && imgOneTransform.TranslateY <= 197)
                    bool1 = true;
                
            }
            else
            {
                bool1 = false;
            }

        }

        private void imgTwo_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgTwoTransform.TranslateX += e.Delta.Translation.X;
            imgTwoTransform.TranslateY += e.Delta.Translation.Y;

            if (imgTwoTransform.TranslateX >= 137 && imgTwoTransform.TranslateX <= 162)
            {
                if (imgTwoTransform.TranslateY >= 153 && imgTwoTransform.TranslateY <= 179)
                    bool2 = true;
            }
            else
            {
                bool2 = false;
            }

        
            calculate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            shake();
        }

        private void shake()
        {
            Random rnd = new Random();
            imgOneTransform.TranslateX = rnd.Next(10, 70);
            imgOneTransform.TranslateY = rnd.Next(10, 70);

            imgTwoTransform.TranslateX = rnd.Next(10, 70);
            imgTwoTransform.TranslateY = rnd.Next(10, 70);
            imgThreeTransform.TranslateX = rnd.Next(10, 70);
            imgThreeTransform.TranslateY = rnd.Next(10, 70);
            imgFourTransform.TranslateX = rnd.Next(10, 70);
            imgFourTransform.TranslateY = rnd.Next(10, 70);
            imgFiveTransform.TranslateX = rnd.Next(10, 70);
            imgFiveTransform.TranslateY = rnd.Next(10, 70);
            imgSixTransform.TranslateX = rnd.Next(10, 70);
            imgSixTransform.TranslateY = rnd.Next(10, 70);
            imgSevenTransform.TranslateX = rnd.Next(10, 70);
            imgSevenTransform.TranslateY = rnd.Next(10, 70);
            imgEightTransform.TranslateX = rnd.Next(10, 70);
            imgEightTransform.TranslateY = rnd.Next(10, 70);
            imgNineTransform.TranslateX = rnd.Next(10, 70);
            imgNineTransform.TranslateY = rnd.Next(10, 70);
        }

        private void imgThree_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgThreeTransform.TranslateX += e.Delta.Translation.X;
            imgThreeTransform.TranslateY += e.Delta.Translation.Y;

            if (imgThreeTransform.TranslateX >= 249 && imgThreeTransform.TranslateX <= 273)
            {
                if (imgThreeTransform.TranslateY >= 132 && imgThreeTransform.TranslateY <= 159)
                    bool3 = true;
            }
            else
            {
                bool3 = false;
            }

      
            calculate();
        }

        private void imgFour_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgFourTransform.TranslateX += e.Delta.Translation.X;
            imgFourTransform.TranslateY += e.Delta.Translation.Y;

            if (imgFourTransform.TranslateX >= -117 && imgFourTransform.TranslateX <= -91)
            {
                if (imgFourTransform.TranslateY >= 263 && imgFourTransform.TranslateY <= 288)
                    bool4 = true;
            }
            else
            {
                bool4 = false;
            }


            calculate();
        }

        private void imgFive_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgFiveTransform.TranslateX += e.Delta.Translation.X;
            imgFiveTransform.TranslateY += e.Delta.Translation.Y;

            if (imgFiveTransform.TranslateX >= 0 && imgFiveTransform.TranslateX <= 21)
            {
                if (imgFiveTransform.TranslateY >= 243 && imgFiveTransform.TranslateY <= 268)
                    bool5 = true;
            }
            else
            {
                bool5 = false;
            }


            calculate();
        }

        private void imgSix_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {

            imgSixTransform.TranslateX += e.Delta.Translation.X;
            imgSixTransform.TranslateY += e.Delta.Translation.Y;


            if (imgSixTransform.TranslateX >= 108 && imgSixTransform.TranslateX <= 133)
            {
                if (imgSixTransform.TranslateY >= 221 && imgSixTransform.TranslateY <= 247)
                    bool6 = true;
            }
            else
            {
                bool6 = false;
            }


           
            calculate();
        }

        private void imgSeven_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgSevenTransform.TranslateX += e.Delta.Translation.X;
            imgSevenTransform.TranslateY += e.Delta.Translation.Y;

            if (imgSevenTransform.TranslateX >= -259 && imgSevenTransform.TranslateX <= -233)
            {
                if (imgSevenTransform.TranslateY >= 351 && imgSevenTransform.TranslateY <= 379)
                    bool7 = true;
            }
            else
            {
                bool7 = false;
            }

   
            calculate();
        }

        private void imgEight_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgEightTransform.TranslateX += e.Delta.Translation.X;
            imgEightTransform.TranslateY += e.Delta.Translation.Y;

            if (imgEightTransform.TranslateX >= -145 && imgEightTransform.TranslateX <= -119)
            {
                if (imgEightTransform.TranslateY >= 331 && imgEightTransform.TranslateY <= 357)
                    bool8 = true;
            }
            else
            {
                bool8 = false;
            }

            calculate();
        }

        private void imgNine_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            imgNineTransform.TranslateX += e.Delta.Translation.X;
            imgNineTransform.TranslateY += e.Delta.Translation.Y;

            if (imgNineTransform.TranslateX >= -33 && imgNineTransform.TranslateX <= -6)
            {
                if (imgNineTransform.TranslateY >= 310 && imgNineTransform.TranslateY <= 339)
                    bool9 = true;
            }
            else
            {
                bool9 = false;
            }

            calculate();
        }

        private void calculate()
        {
            if (bool1 && bool2 && bool3 && bool4 && bool5 && bool6 && bool7 && bool8 && bool9 == true)
            {
                textblock_lbl.Text = "Great";
            } else
            {
                textblock_lbl.Text = "Puzzle";
            }
        }

    }
}
