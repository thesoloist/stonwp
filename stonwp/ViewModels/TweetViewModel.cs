using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace stonwp.ViewModels
{
    public class TweetViewModel : INotifyPropertyChanged
    {

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("id");
                }
            }
        }

        private string _body;
        public string body
        {
            get
            {
                return _body;
            }
            set
            {
                if (value != _body)
                {
                    _body = value;
                    NotifyPropertyChanged("body");
                }
            }
        }
        private string _created_at;
        public string created_at
        {
            get
            {
                return created_at;
            }
            set
            {
                if (value != _created_at)
                {
                    _created_at = value;
                    NotifyPropertyChanged("created_at");
                }

            }
        }

        private int _user_id;
        private string _user_username;
        private string _user_name;
        private Uri _user_avatar_url;
        private Uri _user_avatar_url_ssl;
        
        private List<int> _symbol_id;
        private List<string> _symbol;
        

        private string _source;
        public string source
        {
            get
            {
                return _source;
            }
            set
            {
                if (value != source)
                {
                    _source = value;
                    NotifyPropertyChanged("source");
                };
            }
        }
        private string _source_url;
        public string source_url
        {
            get
            {
                return _source_url;
            }
            set
            {
                if (value != source_url)
                {
                    _source_url = value;
                    NotifyPropertyChanged("source_url");

                };
            }
        }

        private string _symbols;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
