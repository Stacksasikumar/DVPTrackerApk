
using DVPTracker.ViewModel;
using Firebase.Database;
using Firebase.Database.Query;
using Refractored.FabControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace DVPTracker.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teamchat : ContentPage
    {
        public readonly string UserName;
        public Teamchat()
        {
            if (Application.Current.Properties.ContainsKey("Username"))
            {
                UserName = Application.Current.Properties["Username"] as string;

            }
            InitializeComponent();
            TeamChatViewModel teamChatViewModel = new TeamChatViewModel();

            BindingContext = teamChatViewModel;
            this.Appearing += (sender, e) => ScrollToEnd();

        }
        private void ScrollToEnd()
        {
            if (BindingContext is TeamChatViewModel viewModel && viewModel.AllTeamChats.Count > 0)
            {
                var lastTask = viewModel.AllTeamChats[viewModel.AllTeamChats.Count - 1];
                TeamChatView.ScrollTo(lastTask, ScrollToPosition.End, true);
            }
        }
      
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            Chats team = new Chats
            {
                SenderName = UserName != null ? UserName: "Sasikumar",
                Message = recordData.Text,
                Timestamp = DateTime.Now,    
                
            };

            TeamChatViewModel teamChatViewModel = new TeamChatViewModel();
            teamChatViewModel.SendMessage(team);
            BindingContext = teamChatViewModel; 
            recordData.Text = "";

            


       
        }
    }
}