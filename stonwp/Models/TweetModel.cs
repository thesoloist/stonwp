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

namespace stonwp.Model
{
    public class TweetModel : INotifyPropertyChanged
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

        private String _body;
        public String body
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

        private String _created_at;
        public String created_at
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
        public int user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                if (value != _user_id)
                {
                    _user_id = value;
                    NotifyPropertyChanged("user_id");
                }
            }
        }

        private String _user_username;
        public String user_username
        {
            get
            {
                return _user_username;
            }
            set
            {
                if (value != _user_username)
                {
                    _user_username = value;
                    NotifyPropertyChanged(user_username);
                }
            }
        }

        private String _user_name;
        public String user_name
        {
            get
            {
                return _user_name;
            }
            set
            {
                if (value != _user_name)
                {
                    _user_name = value;
                    NotifyPropertyChanged("user_name");
                }
            }
        }

        private String _user_avatar_url;
        public String user_avatar_url
        {
            get
            {
                return _user_avatar_url;
            }
            set
            {
                _user_avatar_url = value;
                NotifyPropertyChanged("user_avatar_url");
            }
        }
        private String _user_avatar_url_ssl;
        public String user_avatar_url_ssl
        {
            get
            {
                return _user_avatar_url_ssl;
            }
            set
            {
                if (value != user_avatar_url_ssl)
                {
                    _user_avatar_url_ssl = value;
                    NotifyPropertyChanged("user_avatar_url_ssl");
                }
            }
        }

        private String _source;
        public String source
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
