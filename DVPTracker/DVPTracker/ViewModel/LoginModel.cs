using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVPTracker.ViewModel
{
    public class LoginModel
    {
        public static LoginModel loginModel = new LoginModel();
      
     

        public static List<UserCredentials> Credentials = new List<UserCredentials>
        {
            new UserCredentials { Username = "Sasi", Password = "dvp" },
            new UserCredentials { Username = "Lenin", Password = "dvp" },
            new UserCredentials { Username = "Praveen", Password = "dvp" },
            new UserCredentials { Username = "Prasanth", Password = "dvp" },
            new UserCredentials { Username = "Raj", Password = "dvp" },
            new UserCredentials { Username = "Santhosh", Password = "dvp" },
            new UserCredentials { Username = "Siva", Password = "dvp" },
            new UserCredentials { Username = "Tharini", Password = "dvp" }
        };

        public static string GetUserName(string username)
        {
            var user = LoginModel.Credentials.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            return user.Username;
        }
        public static UserValidationResult Validate(string username, string password)
        {
            var user = LoginModel.Credentials.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
                return UserValidationResult.InvalidUsername;

            if (user.Password != password)
                return UserValidationResult.InvalidPassword;

            return UserValidationResult.Valid;
        }

    }

    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public enum UserValidationResult
    {
        Valid,
        InvalidUsername,
        InvalidPassword
    }
}
