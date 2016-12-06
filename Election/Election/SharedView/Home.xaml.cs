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
    public partial class Home : ContentPage
    {
        HomeModel model = new HomeModel();
        
        public Home()
        {
            InitializeComponent();
            SubmitBtn.Clicked += OnSubmitAsync;
        }


        async public void OnSubmitAsync(object sender, EventArgs args)
        {
            model.County = CountyEntry.Text.ToLower();
            model.State = StateEntry.Items[StateEntry.SelectedIndex].ToLower();
            model.Type = ElectionTypeEntry.Items[ElectionTypeEntry.SelectedIndex].ToLower();

            List<SharedModel.Election> elections =  await ElectionServices.GetElectionsAsync(model.State, model.County, model.Type);

            //var result = new Result(elections);
            //result.BindingContext = elections;
            await Navigation.PushModalAsync(new Result(elections));
        }

    }
}
