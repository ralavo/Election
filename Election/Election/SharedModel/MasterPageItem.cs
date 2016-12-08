using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace Election.SharedView
{
    //This class define the property of the Page declared in the MasterPage
    public class MasterPageItem
    {
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}



   

