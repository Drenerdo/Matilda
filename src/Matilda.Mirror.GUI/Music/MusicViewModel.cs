using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Matilda.Mirror.GUI.Music
{
   public class MusicViewModel : PropertyChangedBase
    {
        private string soundcloudAPI = "dbb0f63c81d06df74eb4f9d130a4898a";
        private string scLink = "http://api.soundcloud.com/";
        private string scAPIUsers = "users/";
        private string scAPITracks = "tracks?client_id=";
        private string scAPIPlaylist = "playlists?client_id=";
        private string profile = "prince";
        private string streamURLPostfix = "?client_id=";
        private string noStreamableMessage = "Sorry, this song is not stream able.";

        private ObservableCollection<PlayList> playList;
        public ObservableCollection<PlayList> PlayList
        {
            get
            {
                return playList;
            }
            set
            {
                if (playList != value)
                {
                    playList = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private  ObservableCollection<Track> trackList;
        public  ObservableCollection<Track> TrackList
        {
            get
            {
                return trackList;
            }
            set
            {
                if (trackList != value)
                {
                    trackList = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private UserDetail userDetails;
        public UserDetail UserDetails
        {
            get
            {
                return userDetails;
            }
            set
            {
                if (userDetails != value)
                {
                    userDetails = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private PlayList selectedPlayList;
        public PlayList SelectedPlayList
        {
            get
            {
                return selectedPlayList;
            }
            set
            {
                if (selectedPlayList != value)
                {
                    selectedPlayList = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private Track currentTrack;
        public Track CurrentTrack
        {
            get
            {
                return currentTrack;
            }
            set
            {
                if (currentTrack != value)
                {
                    currentTrack = value;
                    NotifyPropertyChanged();
                }
            }
        }
       
        private Visibility isCurrentTrackViewVisible=Visibility.Collapsed;
        public Visibility IsCurrentTrackViewVisible
        {
            get
            {
                return isCurrentTrackViewVisible;
            }
            set
            {
                if (isCurrentTrackViewVisible != value)
                {
                    isCurrentTrackViewVisible = value;
                    NotifyPropertyChanged();
                }
            }
        }
        private ImageSource imagePlay_Pause = new BitmapImage(new Uri("ms-appx:///Images/MusicPlayer Icons/pause.png"));
        public ImageSource ImagePlay_Pause
        {
            get
            {
                return imagePlay_Pause;
            }
            set
            {
                if (imagePlay_Pause != value)
                {
                    imagePlay_Pause = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private bool isDataLoaded;
        public bool IsDataLoaded
        {
            get
            {
                return isDataLoaded;
            }
            set
            {
                if (isDataLoaded != value)
                {
                    isDataLoaded = value;
                    NotifyPropertyChanged();
                }
            }
        }
        //constructor
        public MusicViewModel()
        {
            playList = new ObservableCollection<PlayList>();
            TrackList = new ObservableCollection<Track>();
            GetUserDetail();

        }
        //fill tracks from selected playlist
        public void ItemClicked(PlayList item)
        {
            try
            {
                TrackList.Clear();
                SelectedPlayList = item;
                foreach (var track in item.tracks)
                {
                    track.durationStr ="Duration: " + TimeSpan.FromMilliseconds(track.duration).TotalMinutes.ToString("0.00").ToString() + " mins";
                    TrackList.Add(track);
                }
            }
            catch(Exception ex)
            {

            }
           
        }

        //detail of current track
        public void CurrentTrackClicked(Track item)
        {
            try
            {
                if(item.streamable==true)
                {                  
                    IsCurrentTrackViewVisible = Visibility.Visible;
                    item.stream_url = item.stream_url + streamURLPostfix + soundcloudAPI;
                     CurrentTrack = item;
                }
                else
                {
                    MessageDialog msg = new MessageDialog(noStreamableMessage);
                    msg.ShowAsync();
                }         
            }
            catch (Exception ex)
            {

            }

        }
      
       
      
        //Function to read user detail
        public async Task GetUserDetail() 
        {
            try
            {
                IsDataLoaded = true;
                HttpClient client = new HttpClient();
                string url = scLink + scAPIUsers + profile + ".json?client_id=" + soundcloudAPI;
                string jsonstring = await client.GetStringAsync(url);
                var response = JsonConvert.DeserializeObject<UserDetail>(jsonstring);
                if (response != null)
                {
                    UserDetails = response;
                    GetUserPlayList();
                }
            }
            catch(Exception ex)
            {
                IsDataLoaded = false;
            }
           
        }

        //get all playlists
        public async Task GetUserPlayList() 
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = scLink + scAPIPlaylist + soundcloudAPI;
                string jsonstring = await client.GetStringAsync(url);
                var response = JsonConvert.DeserializeObject(jsonstring);
                if (response != null)
                {
                    foreach(var item in ((Newtonsoft.Json.Linq.JArray)response))
                    {
                      
                        var playlist = JsonConvert.DeserializeObject<PlayList>(item.ToString());
                        playlist.currentPlaylist = "Current PlayList";
                       
                        PlayList.Add(playlist);
                    }
                }
                IsDataLoaded = false;
            }
            catch(Exception ex)
            {
                IsDataLoaded = false;
            }
           
        }
    }
}
