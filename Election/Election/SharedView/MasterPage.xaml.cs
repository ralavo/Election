using System;
using System.Collections.Generic;
using Election.SharedModel;
using Xamarin.Forms;

namespace Election.SharedView
{
    /*Defines the element that will appear in the master page menu
     */
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            //define the list of element in the masterPageItem
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                TargetType = typeof(Home)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Search",
                TargetType = typeof(Search)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
