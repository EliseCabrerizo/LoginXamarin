
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginLinkedIn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            if (StartPage.LoginMode.Equals("Facebook"))
            {
                txUserId.Text = FacebookAuth.User.Id;
                txUserName.Text = FacebookAuth.User.Name;
            }
           else if (StartPage.LoginMode.Equals("Linkedin"))
            {
                txUserId.Text = LinkedinAuth.User.id;
                txUserName.Text = LinkedinAuth.User.localizedFirstName +" "+ LinkedinAuth.User.localizedLastName;
            }

        }
    }
}