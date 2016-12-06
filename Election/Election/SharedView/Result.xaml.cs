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
        public Result(List<SharedModel.Election> elect)
        {
            InitializeComponent();

            List<SharedModel.Election> elections = elect;

            listView.ItemsSource = (IEnumerable<SharedModel.Election>) elections;
        }
    }
}
