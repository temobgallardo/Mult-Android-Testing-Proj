using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Library.Core;

namespace Library.Droid
{
    public class LauncherProviderFaker
    {
        public string GetString(string value)
        {
            return Utils.TransformString(value);
        }
    }
}