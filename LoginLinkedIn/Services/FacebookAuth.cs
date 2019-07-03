using LoginLinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Auth;
using Xamarin.Forms;

namespace LoginLinkedIn
{
    public static class FacebookAuth
    {
        public static UserM User;

        public static Action SuccessfulLoginAction
        {
            get
            {
                return new Action(() =>
               {
                   Application.Current.MainPage = new HomePage();
               });
            }
        }

        public static OAuth2Authenticator FacebookAuthByClientId()
        {
            Constante temp = new Constante();
             return new OAuth2Authenticator
           (
               clientId: temp.GetClientIdF(),
               scope: "",
               authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
               redirectUrl: new Uri(temp.GetRedirectUrlF())
           );
        }
    }

}
