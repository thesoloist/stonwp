using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Controls.Primitives;
using System.IO.IsolatedStorage;
using stonwp.Resources;

namespace stonwp
{
    public partial class SettingsPage : PhoneApplicationPage
    {
        private String auth_url = String.Concat("https://api.stocktwits.com/api/2/oauth/authorize?client_id=", AppResources.OAuth_id, "&response_type=token&redirect_uri=http://daihuaxin.com&scope=read,watch_lists,publish_messages,publish_watch_lists,follow_users,follow_stocks");
        private IsolatedStorageSettings userSettings = IsolatedStorageSettings.ApplicationSettings;
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (userSettings.Contains("access_token"))
            {
                userSettings.Remove("access_token");
                Login_Button.Content = "Login";
                AutoRefresh_Toggle.IsEnabled = false;
            }
            else
            {
                //Login_Browser.Visibility = System.Windows.Visibility.Visible;
                AutoRefresh_Toggle.Visibility = System.Windows.Visibility.Collapsed;
                Login_Browser.Navigate(new Uri(auth_url));
            }
        }

        private void Login_Browser_Nav_EventHandler(object sender, NavigatingEventArgs e)
        {
            Debug.WriteLine(e.Uri.ToString());
            if (e.Uri.ToString().Contains("daihuaxin.com/#access_token="))
            {
                String[] code = e.Uri.ToString().Split('=');
                Debug.WriteLine(code[1]);
                userSettings.Add("access_token", code[1]);
                Login_Browser.Visibility = System.Windows.Visibility.Collapsed;
                AutoRefresh_Toggle.Visibility = System.Windows.Visibility.Visible;
                AutoRefresh_Toggle.IsEnabled = true;
                Login_Button.Content = "Logout";
            }
            else if (e.Uri.ToString().Contains("javascript"))
            {
                Login_Browser.Navigate(new Uri(auth_url));
            }
            else if (e.Uri.ToString().Contains("signin"))
            {
                Login_Browser.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}