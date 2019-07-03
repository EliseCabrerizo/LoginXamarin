using LoginLinkedIn.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Auth;
using Xamarin.Forms;

namespace LoginLinkedIn
{
    public static class LinkedinAuth
    {
        public static UserL User;
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
             return new OAuth2Authenticator
           (
               clientId: "779d1jbf1ktdw7",
               clientSecret: "bag9wYLK9IlfQwYR",
               scope: "r_liteprofile",
               authorizeUrl: new Uri("https://www.linkedin.com/uas/oauth2/authorization"),
               redirectUrl: new Uri("https://www.linkedin.com/in/camille-morand-b2017110b/"),
               accessTokenUrl: new Uri("https://www.linkedin.com/uas/oauth2/accessToken")
           );
        }
    }

}
