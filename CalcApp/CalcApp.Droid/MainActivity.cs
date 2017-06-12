﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace CalcApp.Droid
{
    [Activity(Label = "CalcApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ////TabLayoutResource = Resource.Layout.tabs;
            ////ToolbarResource = Resource.Layout.toolbar;

            //base.OnCreate(bundle);

            //global::Xamarin.Forms.Forms.Init(this, bundle);
            ////LoadApplication(new App(new AndroidInitializer()));
            //LoadApplication(new App());

            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

