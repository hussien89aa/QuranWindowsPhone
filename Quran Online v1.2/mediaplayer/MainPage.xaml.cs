using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using mediaplayer.Resources;
using System.Windows.Threading;
using System.IO.IsolatedStorage;
using System.IO;
using Microsoft.Phone.BackgroundAudio;
 
namespace mediaplayer
{
    public partial class MainPage : PhoneApplicationPage
    {
       
        public MainPage()
        {
            InitializeComponent();


        }

       
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if ((PlayState.Playing == BackgroundAudioPlayer.Instance.PlayerState) && (LnaguageClass. Firstentry == true))
            {
                 
                BackgroundAudioPlayer.Instance.Pause();
                string filePath = "authorAYA.txt";
                using (var store = IsolatedStorageFile.GetUserStoreForApplication())
                {

                     
                        using (StreamReader reader = new StreamReader(store.OpenFile(filePath, FileMode.Open, FileAccess.Read)))
                        {
                             
                            string contents = reader.ReadLine();
                   string[] OneAya = contents.Split('*');
                   LnaguageClass.ISBackgroundMusic = 2;
                   this.NavigationService.Navigate(new Uri("/PlayList.xaml?ServerName=" + OneAya[1] + "*" + OneAya[5], UriKind.Relative));
        
                                
                        }
                    }



            }
            

            LnaguageClass.Firstentry = false;
        }

        private void BuArabic_Click(object sender, RoutedEventArgs e)
        { 
            loadotherinfo();
            LnaguageClass.LanguageSelect = 1;
   this.NavigationService.Navigate(new Uri("/AutherList.xaml", UriKind.Relative));
     //    
        }

        private void Buenglish_Click(object sender, RoutedEventArgs e)
        {
            loadotherinfo();
            LnaguageClass.LanguageSelect = 2;
          this.NavigationService.Navigate(new Uri("/AutherList.xaml", UriKind.Relative));
    
        }

         void loadotherinfo()
        {
            //load ads

            
            //===========

            //  if (rb1.IsChecked==true)
            LnaguageClass.ServerNumber = 1;
           // else
              //  LnaguageClass.ServerNumber = 2;
           
        }
    }




  
}