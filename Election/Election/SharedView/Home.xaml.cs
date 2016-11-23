using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Election.SharedModel;
using Xamarin.Forms;

namespace Election.SharedView
{
    public partial class Home : ContentPage
    {
        HomeModel model = new HomeModel();
        
        public Home()
        {
        //    SubmitBtn.Clicked += OnSubmit;         //when submit button is clicked
            InitializeComponent();
        }
        /*
        private void OnSubmit(Object sender, EventArgs e)
        {
            //model.County = CountyEntry.Text;
            //model.Type = (ElectionType?)ElectionTypeEntry.SelectedIndex;   //cast the election index from integer to election typ enum
        }*/
    }
}
