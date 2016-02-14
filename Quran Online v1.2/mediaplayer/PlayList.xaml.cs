using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Windows.Media;
using System.Threading;
using System.Threading.Tasks;

using System.IO;
using System.IO.IsolatedStorage;
using Windows.Storage;
using System.Windows.Media.Imaging;
using Microsoft.Phone.BackgroundAudio;
 using GoogleAds;

 
namespace mediaplayer
{
    public partial class PlayList : PhoneApplicationPage
    {
        // Constructor


        List<string> quranlay = new List<string>();
        DispatcherTimer mytimer = new DispatcherTimer();
        // name of real folder in server
        string RealServerFolder;
        int AyaIndext = 0;
         
        // this var to select do move to the value of audio 
        //  bool  ISchangeNow = false;
        // this function to change time style
        public string getTime(string strTime)
        {

            return strTime.Substring(0, 8).ToString();

        }

        public PlayList()
        {
            InitializeComponent();

            /// ads
            /// AdView bannerAd = new AdView
           


            mytimer.Interval = new TimeSpan(0, 0, 1);
            mytimer.Tick += new EventHandler(mytimer_tick);
            BackgroundAudioPlayer.Instance.PlayStateChanged += new EventHandler(Instance_PlayStateChanged);
        }

        private void GetArrayDat()
        {

            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {
                string filePath = "authorAYA.txt";
                try
                {
                    
                    if (store.FileExists(filePath))
                    {
                        store.DeleteFile(filePath);
                    }
                    // Create a file in the root.
                    IsolatedStorageFileStream rootFile = store.CreateFile(filePath);
                    rootFile.Close();
                }
                catch (Exception ex) { }
                using (StreamWriter sw = new StreamWriter(store.OpenFile(filePath, FileMode.Open, FileAccess.Write)))
                {
                    int ranagelimit=managment.autherRanageDetermine(RealServerFolder).endread - managment.autherRanageDetermine(RealServerFolder).beginR;
                    string serverRecipter = managment.serverNumber(RealServerFolder);
                    for (int i = 0; i < ranagelimit; i++)
                    {
                        string playAYAName = LnaguageClass.ListAyaRanage[i].ServerName;
                        string select  ; //= "http://server" + serverRecipter + ".mp3quran.net/" + RealServerFolder + "/" + playAYAName + ".mp3";

                        if (LnaguageClass.ServerNumber == 1)

                         select = "http://server" + serverRecipter + ".mp3quran.net/" + RealServerFolder + "/" + playAYAName + ".mp3";
                            else
                            select = "http://www.quran.alrubaye.com/quran/" + RealServerFolder + "/" + playAYAName + ".mp3";

                       
                        IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();
                        string[] files = isoStore.GetFileNames(RealServerFolder + playAYAName + ".mp3");

                        // play file from ,mobile
                        if (files.Length > 0)
                        {
                               //*** for Read Media from Isolated Storage
                                string strMediaName = RealServerFolder + playAYAName + ".mp3";

                                sw.WriteLine(strMediaName + "*" + RealServerFolder + "*" + playAYAName + "*" + LnaguageClass.ListAyaRanage[i].RealName + "*Relative*" + AyaIndext.ToString());

 

                        }
                        // play file online
                        else
                        {

                            sw.WriteLine(select + "*" + RealServerFolder + "*" + playAYAName + "*" + LnaguageClass.ListAyaRanage[i].RealName + "*Absolute*" + AyaIndext.ToString());
 

                        }
                       
                    }
                    sw.Close();
                }// file writing
            }


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //=========== setup background image to button
            //  ImageBrush background = new ImageBrush();
            // background.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"/ImageSetting/img_btn_forward.png", UriKind.Relative));
            // Forword.Background = background;
            //======================
            string contents;
            NavigationContext.QueryString.TryGetValue("ServerName", out contents );
            string[] OneAya = contents.Split('*');
            RealServerFolder = OneAya[0];
            int newaya = Convert.ToInt32(OneAya[1]);
            LnaguageClass.OtherFolderName = RealServerFolder;



            LnaguageClass.GuranAya(RealServerFolder);
            ListAuther65.ItemsSource = null;
            ListAuther65.ItemsSource = LnaguageClass.ListAyaRanage;  //LnaguageClass.AutherList();


//GetArrayDat();
            if (LnaguageClass.ISBackgroundMusic != 2)
                if ((PlayState.Playing == BackgroundAudioPlayer.Instance.PlayerState) || (PlayState.Paused == BackgroundAudioPlayer.Instance.PlayerState))
            { 
                LnaguageClass.ISBackgroundMusic = 3;
                BackgroundAudioPlayer.Instance.Stop();

            }
             
            SelectedForPlay(newaya);

        }
        TimeSpan tsTimer;
        private void mytimer_tick(object sender, EventArgs e)
        {
            tsTimer = new TimeSpan(0, 0, 0, Convert.ToInt32(BackgroundAudioPlayer.Instance.Position.TotalSeconds));
            txtpos.Text = getTime(tsTimer.ToString());

            bupos.Value = BackgroundAudioPlayer.Instance.Position.TotalSeconds; // bupos.Value + 1;

            //if (mp.Position.TotalMinutes==0)
            //SelectedForPlay(AyaIndext+1);
        }



      


        private void Forword_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mytimer.Stop();
            double SliderValue = 5 + BackgroundAudioPlayer.Instance.Position.TotalSeconds;

            if (SliderValue > bupos.Maximum)
            {
                SliderValue = 0;
            }

            TimeSpan ts = new TimeSpan(0, 0, 0, (int)SliderValue ,0);
            BackgroundAudioPlayer.Instance.Position = ts;
            mytimer.Start();
            //  MessageBox.Show(SliderValue.ToString());
        }

        private void Backword_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mytimer.Stop();
            double SliderValue = BackgroundAudioPlayer.Instance.Position.TotalSeconds - 5;
            if (SliderValue < 0)
            {
                SliderValue = 0;
            }
            // Overloaded constructor takes the arguments days, hours, minutes, seconds, miniseconds. 
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)SliderValue);
            BackgroundAudioPlayer.Instance.Position = ts;
            mytimer.Start();
        }

        // get the location of selected item
        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var res = (sender as LongListSelector).SelectedItem as AuthorClass;
            int Sindex = LnaguageClass.ListAyaRanage.IndexOf(res);
            SelectedForPlay(Sindex);


        }
        private void SelectedForPlay(int NewIndex)
        {
            // firt we get the
            var newData1 = new AuthorClass() { ServerName = LnaguageClass.ListAyaRanage[AyaIndext].ServerName, RealName = LnaguageClass.ListAyaRanage[AyaIndext].RealName, StateName = LnaguageClass.ListAyaRanage[AyaIndext].StateName, ImgUrl = "ImageSetting/img_btn_play.png" };
            LnaguageClass.ListAyaRanage.RemoveAt(AyaIndext);
            LnaguageClass.ListAyaRanage.Insert(AyaIndext, newData1);



            // he try to stop some audio

            if ((NewIndex == AyaIndext) && (PlayState.Playing == BackgroundAudioPlayer.Instance.PlayerState)  && (LnaguageClass.ISBackgroundMusic != 3))
            {

                BackgroundAudioPlayer.Instance.Pause();
                //buplay.Content = LnaguageClass.playv();
                //  BitmapImage tn = new BitmapImage();
                // tn.SetSource(Application.GetResourceStream(new Uri(@"ImageSetting/img_btn_play.png", UriKind.Relative)).Stream); tn.SetSource(Application.GetResourceStream(new Uri(@"ImageSetting/img_btn_play.png", UriKind.Relative)).Stream);
                // buplay.Source = tn;  
                LnaguageClass.ISBackgroundMusic = 1;
                return;

            }


            //mark 1
            var newData = new AuthorClass() { ServerName = LnaguageClass.ListAyaRanage[NewIndex].ServerName, RealName = LnaguageClass.ListAyaRanage[NewIndex].RealName, StateName = LnaguageClass.ListAyaRanage[NewIndex].StateName, ImgUrl = "ImageSetting/img_btn_pause_pressed.png" };
            LnaguageClass.ListAyaRanage.RemoveAt(NewIndex);
            LnaguageClass.ListAyaRanage.Insert(NewIndex, newData);

            // if he try to replay pasued audio
            if ((NewIndex == AyaIndext) && (PlayState.Paused == BackgroundAudioPlayer.Instance.PlayerState) && (LnaguageClass.ISBackgroundMusic != 3))
            {

                BackgroundAudioPlayer.Instance.Play();
                LnaguageClass.ISBackgroundMusic = 1;
                return;

            }
            
            // move the location selet to the next
            if (  (PlayState.Paused == BackgroundAudioPlayer.Instance.PlayerState) && (LnaguageClass.ISBackgroundMusic==2))
            {
                AyaIndext = NewIndex;
                BackgroundAudioPlayer.Instance.Play();
                LnaguageClass.ISBackgroundMusic = 1;
                return;

            }

            LnaguageClass.ISBackgroundMusic = 1;
            AyaIndext = NewIndex;
            //MessageBox.Show(AyaIndext.ToString());
            PlayAudio();



        }

        

        /// <summary>
        /// play audio
        /// </summary>
        private void PlayAudio()
        {

            PlayAya.Text = LnaguageClass.playv() + " " + LnaguageClass.ListAyaRanage[AyaIndext].RealName;

            GetArrayDat();
        // loadfile();
            if ((PlayState.Paused == BackgroundAudioPlayer.Instance.PlayerState)) BackgroundAudioPlayer.Instance.Stop();
            BackgroundAudioPlayer.Instance.Play();

            // }
        }
        void loadfile()
        
        {
            List<AudioTrack> _playList = new List<AudioTrack>
        {
             

            // A remote URI
            new AudioTrack(new Uri("http://server11.mp3quran.net/shatri/018.mp3", UriKind.Absolute), 
                            "Episode 29", 
                            "Windows Phone Radio", 
                            "Windows Phone Radio Podcast",
                            new Uri("shared/media/Episode29.jpg", UriKind.Relative))
        };

         
            string filePath = "authorAYA.txt";
            using (var store = IsolatedStorageFile.GetUserStoreForApplication())
            {

                try
                {
                    
                    string[] OneAya;
                    string contents;
                    using (StreamReader reader = new StreamReader(store.OpenFile(filePath, FileMode.Open, FileAccess.Read)))
                    {
                        contents = reader.ReadLine();
                        while (!(contents == ""))
                        {
                            OneAya = contents.Split('*');

                            if (OneAya[4].Equals("Absolute"))
                            {
                                MessageBox.Show(OneAya[0]);
                                try
                                {
                                    _playList.Add(
                                                                        new AudioTrack(new Uri(OneAya[0], UriKind.Absolute),
                                                              OneAya[1],
                                                              OneAya[2],
                                                              OneAya[3],
                                                              new Uri("shared/media/Episode29.jpg", UriKind.Relative)));
                                    ;
                                    MessageBox.Show(_playList.Count.ToString());
                                }
                                catch (Exception ez) { MessageBox.Show(ez.Message); };
                            }
                            else
                            {
                                MessageBox.Show(OneAya[1]);
                            }
                            contents = reader.ReadLine();
                        }
                    }
                } 
                catch (IsolatedStorageException ex)
                {


                }


            }
        }
        private void Budownloads_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Downloads.xaml", UriKind.Relative));
        }



 


        private void Image_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MoveNext();
        }
        private void MoveNext()
        {
            int tempAyaIndext = AyaIndext + 1;
            if (tempAyaIndext > LnaguageClass.ListAyaRanage.Count - 1)
                tempAyaIndext = 0;
            SelectedForPlay(tempAyaIndext);
        }
        // move to previous AYA to play it.
        private void Image_MouseLeftButtonUp_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int tempAyaIndext = AyaIndext - 1;
            // if he on first item go to last one
            if (tempAyaIndext < 0)
                tempAyaIndext = LnaguageClass.ListAyaRanage.Count - 1;
            SelectedForPlay(tempAyaIndext);
        }



        private void bupos_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            mytimer.Stop();
            int secondsn = Convert.ToInt32(bupos.Value);
            BackgroundAudioPlayer.Instance.Position = new TimeSpan(0, 0, 0, secondsn);
 mytimer.Start();
        }

        










        void Instance_PlayStateChanged(object sender, EventArgs e)
        {

           // MessageBox.Show(BackgroundAudioPlayer.Instance.PlayerState .ToString());
            switch (BackgroundAudioPlayer.Instance.PlayerState)
            {
                case PlayState.Playing:
                    {
                        bupos.Minimum = 0;
                        bupos.Value = 0;
                        bupos.Maximum = BackgroundAudioPlayer.Instance.Track.Duration.TotalSeconds;

                        TimeSpan ts = new TimeSpan(0, 0, 0, Convert.ToInt32(BackgroundAudioPlayer.Instance.Track.Duration.TotalSeconds));
                        txtlength.Text = getTime(ts.ToString());
                        mytimer.Start();
                        
                        break;
                    }

                //case PlayState.Paused:
                case PlayState.Stopped:
                    {
                        //MessageBox.Show(BackgroundAudioPlayer.Instance.Position.TotalSeconds.ToString());
                        //mytimer.Stop();
                        if (bupos.Value+1 >= bupos.Maximum)
                        {
                            mytimer.Stop();
                            bupos.Value = 0;
                            MoveNext();
                        }
                        break;
                    }
                //case PlayState.Paused:
                case PlayState.TrackEnded:
                    {
                        MessageBox.Show(BackgroundAudioPlayer.Instance.Position.TotalSeconds.ToString());
                       // mytimer.Stop();
                     //  MoveNext();
                        //mytimer.Stop();
                        break;
                    }
            }
        }

        private void AddBackgroundTransferButton_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Downloads.xaml", UriKind.RelativeOrAbsolute));
        }

        





    }
}