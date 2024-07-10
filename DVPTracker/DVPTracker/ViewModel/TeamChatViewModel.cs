using DVPTracker.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DVPTracker.ViewModel
{
    public class TeamChatViewModel : INotifyPropertyChanged
    {
       
        public ObservableCollection<Chats> AllTeamChats { get; set; } = new ObservableCollection<Chats>(); 
        public event PropertyChangedEventHandler PropertyChanged;
        FirebaseClient firebaseClient = new FirebaseClient("https://strs-4c156-default-rtdb.firebaseio.com/");
        
        public TeamChatViewModel()
        {
            
            SubscribeToFirebase();

        }

        public void SendMessage(Chats team)
        {
            firebaseClient.Child("Records").PostAsync(new Chats
            {
                SenderName = team.SenderName,
                Message = team.Message,
                Timestamp = team.Timestamp
            });
        }
        public void SubscribeToFirebase()
        {
            var collection = firebaseClient
             .Child("Records")
             .AsObservable<Chats>()
             .Subscribe((dbevent) =>
             {
                 if (dbevent.Object != null)
                 {
                     AllTeamChats.Add(dbevent.Object);
                 }
             });

        }
    }

    public class Chats
    {
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
