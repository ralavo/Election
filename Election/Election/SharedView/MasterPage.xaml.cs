using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Election.SharedView
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "home.png",
                //TargetType = typeof(ContactsPage)
                TargetType = typeof(Home)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "API",
                IconSource = "api.png",
                TargetType = typeof(API)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Documentation",
                IconSource = "documentation.png",
                TargetType = typeof(Documentation)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Register",
                IconSource = "register.png",
                TargetType = typeof(Register)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Log In",
                IconSource = "login.png",
                TargetType = typeof(Login)
            });

            listView.ItemsSource = masterPageItems;
        }
    }

}
