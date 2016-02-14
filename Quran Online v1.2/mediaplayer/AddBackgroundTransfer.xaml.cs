using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.BackgroundTransfer;
using System.IO.IsolatedStorage;
 
namespace mediaplayer
{
    public partial class AddBackgroundTransfer : PhoneApplicationPage
    {
        private readonly List<string> urls =
            new List<string>
    {
      "http://www.contoso.com/assets/cms/images/samples/windowsphonetestfile1.png",  
      "http://www.contoso.com/assets/cms/images/samples/windowsphonetestfile2.png",  
      "http://www.contoso.com/assets/cms/images/samples/windowsphonetestfile3.png",  
      "http://www.contoso.com/assets/cms/images/samples/windowsphonetestfile4.png",  
      "http://www.contoso.com/assets/cms/images/samples/windowsphonetestfile5.png",  
      "http://server11.mp3quran.net/shatri/002.mp3",
    };
        public AddBackgroundTransfer()
        {
            InitializeComponent();

            // Bind the list of URLs to the ListBox.
           // URLListBox.ItemsSource =  urls;
           
            LnaguageClass.GuranAya(LnaguageClass.OtherFolderName);
            ListAuther65.ItemsSource = null;
            ListAuther65.ItemsSource = LnaguageClass.ListAyaRanage; 
            // Make sure that the required "/shared/transfers" directory exists
            // in isolated storage.
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (!isoStore.DirectoryExists("/shared/transfers/" ))
                {
                    isoStore.CreateDirectory("/shared/transfers/" );
                   
                }
              
            }
            if (LnaguageClass.LanguageSelect == 1)
            {
                txtonlywifi.Text = "تنزيل فقط في حالة توف شبكات واي فاي";
                txtExternal.Text = "تنزيل فقط عندما يكون الهاتف متصل بمصدر طاقة خارجية";
            }
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Button nb = (Button)sender;
          
            // Check to see if the maximum number of requests per app has been exceeded.
            if (BackgroundTransferService.Requests.Count() >= 25)
            {
                // Note: Instead of showing a message to the user, you could store the
                // requested file URI in isolated storage and add it to the queue later.
                 if (LnaguageClass.LanguageSelect == 1)
                     MessageBox.Show("تجاوز عدد الايات الكلي عدد العناصر المسموح لتنزيلها معا وهي 25 عنصر لذالك قلل عدد السور ");
                else 
                MessageBox.Show("The maximum number of background file transfer requests for this application has been exceeded. ");
                return;
            }

            // Get the URI of the file to be transferred from the Tag property
            // of the button that was clicked.
            // Get the Uri
            string transferFileName = "http://server" + managment.serverNumber(LnaguageClass.OtherFolderName) + ".mp3quran.net/" + LnaguageClass.OtherFolderName + "/" + ((Button)sender).Tag as string  +".mp3";
           
            //string transferFileName = 
            Uri transferUri = new Uri(Uri.EscapeUriString(transferFileName), UriKind.RelativeOrAbsolute);


            // Create the new transfer request, passing in the URI of the file to 
            // be transferred.
            BackgroundTransferRequest transferRequest = new BackgroundTransferRequest( transferUri);

            // Set the transfer method. GET and POST are supported.
            transferRequest.Method = "GET";
            // Get the file name from the end of the transfer URI and create a local URI 
            // in the "transfers" directory in isolated storage.
            string downloadFile =  LnaguageClass.OtherFolderName + transferFileName.Substring(transferFileName.LastIndexOf("/") + 1);
       //  MessageBox.Show("/shared/transfers/" + LnaguageClass.OtherFolderName +  downloadFile);
            Uri downloadUri = new Uri("shared/transfers/" + downloadFile, UriKind.RelativeOrAbsolute);
            transferRequest.DownloadLocation = downloadUri;
            
            // Pass custom data with the Tag property. In this example, the friendly name
            // is passed.
            transferRequest.Tag = downloadFile;
            // If the Wi-Fi-only check box is not checked, then set the TransferPreferences
            // to allow transfers over a cellular connection.
            if (wifiOnlyCheckbox.IsChecked == false)
            {
                transferRequest.TransferPreferences = TransferPreferences.AllowCellular;
            }
            if (externalPowerOnlyCheckbox.IsChecked == false)
            {
                transferRequest.TransferPreferences = TransferPreferences.AllowBattery;
            }
            if (wifiOnlyCheckbox.IsChecked == false && externalPowerOnlyCheckbox.IsChecked == false)
            {
                transferRequest.TransferPreferences = TransferPreferences.AllowCellularAndBattery;
            }
            // Add the transfer request using the BackgroundTransferService. Do this in 
            // a try block in case an exception is thrown.
            try
            {
                BackgroundTransferService.Add(transferRequest);
                nb.IsEnabled = false;
            }
            catch (InvalidOperationException ex)
            {
                if (LnaguageClass.LanguageSelect == 1)
                    MessageBox.Show("هذه السورة تم اضافتها الى قائمة التحميل سابقا");
                else 
                MessageBox.Show("Unable to add background transfer request. " + ex.Message);
            }
            catch (Exception)
            {
                if (LnaguageClass.LanguageSelect == 1)
                    MessageBox.Show("  لا يمكن اضافةالاية الى عناصر قائمة التحميل");
                else 
                MessageBox.Show("Unable to add background transfer request.");
            }
        }











    }
}