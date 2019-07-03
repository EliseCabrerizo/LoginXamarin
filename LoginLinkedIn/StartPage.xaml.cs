using System;
using Xamarin.Forms;

namespace LoginLinkedIn
{
    
    public partial class StartPage : ContentPage
    {
        public static string LoginMode = "";
        public StartPage()
        {
            InitializeComponent();
            
            
        }
        public void Facebook(object sender, EventArgs e)
        {
            LoginMode = "Facebook";
            Navigation.PushModalAsync(new ProviderLoginPage());
        }
        public void Linkedin(object sender, EventArgs e)
        {

            
            LoginMode = "Linkedin";
            Navigation.PushModalAsync(new ProviderLoginPage());
        }

    }
}
