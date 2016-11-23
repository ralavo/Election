using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Election.SharedModel
{
    public class HomeModel
    {
        public string County { get; set; }
        public ElectionType? Type { get; set; }
    }
}
