
using DVPTracker.ViewModel;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DVPTracker.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teamchat : ContentPage
    {
       
        public Teamchat()
        {
            InitializeComponent();
            TeamChatViewModel teamChatViewModel = new TeamChatViewModel();
            
            BindingContext = teamChatViewModel;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            Chats team = new Chats
            {
                SenderName = "Sasi",
                Message = recordData.Text
            };

            TeamChatViewModel teamChatViewModel = new TeamChatViewModel();
            teamChatViewModel.SendMessage(team);
            BindingContext = teamChatViewModel; 
            recordData.Text = "";

            


       
        }
    }
}