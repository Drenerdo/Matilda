using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Matilda.Mirror.GUI.Music
{
    public sealed partial class MusicViewControl : UserControl
    {
        public MusicViewModel ViewModel
        {
            get { return DataContext as MusicViewModel; }
        }
        public MusicViewControl()
        {
            this.InitializeComponent();
            
           
        }

        //select playlist from collection of list
        private void playlists_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                
                var item = e.ClickedItem as PlayList;
                if (item != null)
                {

                    ViewModel.ItemClicked(e.ClickedItem as PlayList);
                }
            }
            catch (Exception ex)
            { }
           
        }

        //select track from track list
        private void currentplaylist_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var item = e.ClickedItem as Track;

                if (item != null)
                {
                    ViewModel.CurrentTrackClicked(e.ClickedItem as Track);
                    this.player.Play();
                }
            }
            catch(Exception ex)
            { }
           
        }
        
        //track play/pause
        private void btnplaypause_Click(object sender, RoutedEventArgs e)
        {
            if (((BitmapImage)ViewModel.ImagePlay_Pause).UriSource.AbsoluteUri.Contains("pause"))
            {
                ViewModel.ImagePlay_Pause = new BitmapImage(new Uri("ms-appx:///Images/MusicPlayer Icons/play.png"));
                this.player.Pause();
            }
            else
            {
                ViewModel.ImagePlay_Pause = new BitmapImage(new Uri("ms-appx:///Images/MusicPlayer Icons/pause.png")); 
                this.player.Play();
            }

        }
    }
}
