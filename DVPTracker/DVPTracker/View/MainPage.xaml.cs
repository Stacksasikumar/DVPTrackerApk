using DVPTracker.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DVPTracker.View
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        void LoginClick(object sender, EventArgs e)
        {
            try
            {

            
            StoreUsername().ContinueWith(OnMyAsyncMethodFailed, TaskContinuationOptions.OnlyOnFaulted);

            string username ="";
            string password = "";
            if (Application.Current.Properties.ContainsKey("Username") && Application.Current.Properties.ContainsKey("Password"))
            {
       
                 username = Application.Current.Properties["Username"] as string;
                 password = Application.Current.Properties["Password"] as string;
            }

 

            var validationResult = LoginModel.Validate(username, password);
            var useranme = LoginModel.GetUserName(username);

            StoreUsername(useranme).ContinueWith(OnMyAsyncMethodFailed, TaskContinuationOptions.OnlyOnFaulted);

            switch (validationResult)
            {
                case UserValidationResult.Valid:
                    // Navigate to main page or perform login action
                    DisplayAlert("Success", "Login successful!", "OK");
                    Navigation.PushAsync(new HomePage());
                    break;
                case UserValidationResult.InvalidUsername:
                    DisplayAlert("Error", "Invalid username!", "OK");
                    break;
                case UserValidationResult.InvalidPassword:
                    DisplayAlert("Error", "Invalid password!", "OK");
                    break;
            }

            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.Message, "OK"); ;
            }
        }
        public async Task StoreUsername(string username)
        {
            Application.Current.Properties["Username"] = username;
            await Application.Current.SavePropertiesAsync();
        }
        public async Task StoreUsername()
        {
            Application.Current.Properties["Username"] = username.Text;
            Application.Current.Properties["Password"] = password.Text;
            await Application.Current.SavePropertiesAsync();
        }
        public static void OnMyAsyncMethodFailed(Task task)
        {
            Exception ex = task.Exception;
            
        }
    }
}
