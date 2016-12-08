using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Election.SharedModel;
using Xamarin.Forms;
using Election.Services;

namespace Election.SharedView
{
    /* Home Page */
    public partial class Home : ContentPage
    {
        HomeModel model = new HomeModel();
        
        public Home()
        {
            InitializeComponent();
            SubmitBtn.Clicked += OnSubmitAsync;
        }

        /*  Define What is done when the Submit button is clicked
         * defined async because it contains an await method
         */
        async public void OnSubmitAsync(object sender, EventArgs args)
        {
            //When the Submit button is clicked retrieve the data inputted and 
            //insert them in the HomeModel object
            model.County = CountyEntry.Text.ToLower();
            model.State = StateEntry.Items[StateEntry.SelectedIndex].ToLower();
            model.Type = ElectionTypeEntry.Items[ElectionTypeEntry.SelectedIndex].ToLower();

            //check if the field are all inputted
            if (model.County == null || model.State == null || model.Type == null)
            {
                await DisplayAlert("Empty", "Please input all the field", "OK");    //display alert
            }
            else {
                //based on the user input, get a list of elections from the services(Services.ElectionServices.cs)
                List<SharedModel.Election> elections = await ElectionServices.GetElectionsAsync(model.State, model.County, model.Type);

                //Navigate to the esult page
                await Navigation.PushModalAsync(new Result(elections));
            }   
        }
    }
}
