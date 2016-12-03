using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Election.SharedView
{
    public partial class Result : ContentPage
    {
        public Result()
        {
            InitializeComponent();

            List<SharedModel.Election> election = new List<SharedModel.Election>(); //from home xaml

            listView.ItemsSource = election;

            
            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

        }
    }
}
