using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LoLTimer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DateTime BlueTime;
        DateTime RedTime;
        DateTime DragonTime;
        DateTime OpponentBlueTime;
        DateTime OpponentRedTime;
        DateTime BaronTime;

        
        string CurrentButton;
        
        
        DispatcherTimer t = new DispatcherTimer();
        DispatcherTimer t1 = new DispatcherTimer();
        DispatcherTimer t2 = new DispatcherTimer();
        DispatcherTimer t3 = new DispatcherTimer();
        DispatcherTimer t4 = new DispatcherTimer();
        DispatcherTimer t5 = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            t.Tick +=t_Tick;
            t1.Tick +=t1_Tick;
            t2.Tick += t2_Tick;
            t3.Tick += t3_Tick;
            t4.Tick += t4_Tick;
            t5.Tick += t5_Tick;

        }

      

        void t_Tick(object sender, object e)
        {


         ((Button)FindName("BlueButton")).Content = (DateTime.Now.Subtract((BlueTime))).ToString();

            
            if (DateTime.Now >= BlueTime.AddSeconds(300))
            {
                t.Stop();
                ((Button)FindName("BlueButton")).Content = "Buff is up now!";

            } 
        }

        private void t1_Tick(object sender, object e)
        {
            ((Button)FindName("RedButton")).Content = (DateTime.Now.Subtract((RedTime))).ToString();
            if (DateTime.Now >= RedTime.AddSeconds(300))
            {
                t1.Stop();
                ((Button)FindName("RedButton")).Content = "Buff is up now!";

            } 
        }

        private void t3_Tick(object sender, object e)
        {
            ((Button)FindName("OpponentRedButton")).Content = (DateTime.Now.Subtract((OpponentRedTime))).ToString();
            if (DateTime.Now >= OpponentRedTime.AddSeconds(300))
            {
                t3.Stop();
                ((Button)FindName("OpponentRedButton")).Content = "Buff is up now!";

            }
        }

        private void t2_Tick(object sender, object e)
        {
            ((Button)FindName("OpponentBlueButton")).Content = (DateTime.Now.Subtract((OpponentBlueTime))).ToString();
            if (DateTime.Now >= OpponentBlueTime.AddSeconds(300))
            {
                t2.Stop();
                ((Button)FindName("OpponentBlueButton")).Content = "Buff is up now!";

            }
        }

        private void t4_Tick(object sender, object e)
        {
            ((Button)FindName("DragonButton")).Content = (DateTime.Now.Subtract((DragonTime))).ToString();
            if (DateTime.Now >= DragonTime.AddSeconds(360))
            {
                t4.Stop();
                ((Button)FindName("DragonButton")).Content = "Buff is up now!";

            }
        }

        private void t5_Tick(object sender, object e)
        {
            ((Button)FindName("BaronButton")).Content = (DateTime.Now.Subtract((BaronTime))).ToString();
            if (DateTime.Now >= BaronTime.AddSeconds(420))
            {
                t5.Stop();
                ((Button)FindName("BaronButton")).Content = "Buff is up now!";

            }
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            CurrentButton = b.Name;
            switch (b.Name)
            {
                case "BlueButton":
                    BlueTime = DateTime.Now;
                    ((Button)FindName("BlueButton")).Content = "Click Here to Start.";

                    t.Start();

                    break;
                case "RedButton":
                    RedTime = DateTime.Now;               
                    t1.Start();
                    break;
                case "OpponentBlueButton":
                    OpponentBlueTime = DateTime.Now;              
                    t2.Start();
                    break;
                case "OpponentRedButton":
                    OpponentRedTime = DateTime.Now;                   
                    t3.Start();
                    break;
                case "DragonButton":
                    DragonTime = DateTime.Now;                 
                    t4.Start();
                    break;
                case "BaronButton":
                    BaronTime = DateTime.Now;
                    t5.Start();
                    break;
            }
            
          
           

        }

        

        
       
   

        
       
    }
}

