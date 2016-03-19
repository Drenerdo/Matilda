﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Matilda.Mirror.GUI.Music
{
   public class MusicModel
    {

    }
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Subscription
    {
        public Product product { get; set; }
    }

    public class UserDetail
    {
        public int id { get; set; }
        public string kind { get; set; }
        public string permalink { get; set; }
        public string username { get; set; }
        public string last_modified { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
        public string avatar_url { get; set; }
        public object country { get; set; }
        public object first_name { get; set; }
        public object last_name { get; set; }
        public string full_name { get; set; }
        public object description { get; set; }
        public object city { get; set; }
        public object discogs_name { get; set; }
        public object myspace_name { get; set; }
        public string website { get; set; }
        public string website_title { get; set; }
        public bool online { get; set; }
        public int track_count { get; set; }
        public int playlist_count { get; set; }
        public string plan { get; set; }
        public int public_favorites_count { get; set; }
        public List<Subscription> subscriptions { get; set; }
        public int followers_count { get; set; }
        public int followings_count { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string kind { get; set; }
        public string permalink { get; set; }
        public string username { get; set; }
        public string last_modified { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
        public string avatar_url { get; set; }
    }

    public class CreatedWith
    {
        public int id { get; set; }
        public string kind { get; set; }
        public string name { get; set; }
        public string uri { get; set; }
        public string permalink_url { get; set; }
        public string external_url { get; set; }
    }

    public class Track
    {
        public string kind { get; set; }
        public int id { get; set; }
        public string created_at { get; set; }
        public int user_id { get; set; }
        public int duration { get; set; }
        public string durationStr { get; set; }
        public bool commentable { get; set; }
        public string state { get; set; }
        public int original_content_size { get; set; }
        public string last_modified { get; set; }
        public string sharing { get; set; }
        public string tag_list { get; set; }
        public string permalink { get; set; }
        public bool streamable { get; set; }
        public string embeddable_by { get; set; }
        public bool downloadable { get; set; }
        public string purchase_url { get; set; }
        public object label_id { get; set; }
        public string purchase_title { get; set; }
        public string genre { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string label_name { get; set; }
        public string release { get; set; }
        public string track_type { get; set; }
        public string key_signature { get; set; }
        public string isrc { get; set; }
        public string video_url { get; set; }
        public object bpm { get; set; }
        public int? release_year { get; set; }
        public int? release_month { get; set; }
        public int? release_day { get; set; }
        public string original_format { get; set; }
        public string license { get; set; }
        public string uri { get; set; }
        public User user { get; set; }
        public string permalink_url { get; set; }
        public string artwork_url { get; set; }
        public string waveform_url { get; set; }
        public string stream_url { get; set; }
        public int playback_count { get; set; }
        public int download_count { get; set; }
        public int favoritings_count { get; set; }
        public int comment_count { get; set; }
        public string attachments_uri { get; set; }
        public string download_url { get; set; }
        public CreatedWith created_with { get; set; }
    }

    public class CreatedWith2
    {
        public string permalink_url { get; set; }
        public string name { get; set; }
        public string external_url { get; set; }
        public string uri { get; set; }
        public string creator { get; set; }
        public int id { get; set; }
        public string kind { get; set; }
    }

    public class User2
    {
        public string permalink_url { get; set; }
        public string permalink { get; set; }
        public string username { get; set; }
        public string uri { get; set; }
        public string last_modified { get; set; }
        public int id { get; set; }
        public string kind { get; set; }
        public string avatar_url { get; set; }
    }

    public class PlayList
    {
        public string currentPlaylist { get; set; }
        public int duration { get; set; }
        public object release_day { get; set; }
        public string permalink_url { get; set; }
        public string genre { get; set; }
        public string permalink { get; set; }
        public object purchase_url { get; set; }
        public object release_month { get; set; }
        public string description { get; set; }
        public string uri { get; set; }
        public object label_name { get; set; }
        public string tag_list { get; set; }
        public object release_year { get; set; }
        public int track_count { get; set; }
        public int user_id { get; set; }
        public string last_modified { get; set; }
        public string license { get; set; }
        public List<Track> tracks { get; set; }
        public object playlist_type { get; set; }
        public int id { get; set; }
        public bool? downloadable { get; set; }
        public string sharing { get; set; }
        public string created_at { get; set; }
        public object release { get; set; }
        public string kind { get; set; }
        public string title { get; set; }
        public object type { get; set; }
        public object purchase_title { get; set; }
        public CreatedWith2 created_with { get; set; }
        public string artwork_url { get; set; }
        public object ean { get; set; }
        public bool? streamable { get; set; }
        public User2 user { get; set; }
        public string embeddable_by { get; set; }
        public object label_id { get; set; }
    }
    public class PlayListRoot
    {
        List<PlayList> List { get; set; }
    }
    public class CurrentTrack
    {
     
        public ImageSource image_url { get; set; }
        public string stream_uri { get; set; }
        public string title { get; set; }
        
    }
}
