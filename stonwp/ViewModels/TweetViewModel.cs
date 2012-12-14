using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stonwp.Model;

namespace stonwp.ViewModels
{
    class TweetViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TweetModel> TweetCollection
        {
            get;
            private set;
        }

        public TweetViewModel() { 
            this.TweetCollection = new ObservableCollection<TweetModel>();
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
