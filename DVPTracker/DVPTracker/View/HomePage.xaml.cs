using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace DVPTracker.View
{
    [DesignTimeVisible(false)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void PendingtaskClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pendingtask());
        }

        void TeamchatClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Teamchat());
        }
    }
}
