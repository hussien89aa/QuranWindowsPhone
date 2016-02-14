using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace mediaplayer
{
    public partial class AutherList : PhoneApplicationPage
    {
        public AutherList()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        { // load data to the list 
            LnaguageClass.AutherList();

            titileAuther.Text = LnaguageClass.AuthorNmae();
            ListAuther65.ItemsSource = null;
            ListAuther65.ItemsSource = LnaguageClass.AutherListInfo;  //LnaguageClass.AutherList();

        }

       
        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/PlayList.xaml?ServerName=" + (ListAuther65.SelectedItem as AuthorClass).ServerName + "*0", UriKind.Relative));
        
        }
    }
}