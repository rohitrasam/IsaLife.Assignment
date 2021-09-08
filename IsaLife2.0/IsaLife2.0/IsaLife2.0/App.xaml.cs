using FreshMvvm;
using IsaLifeUpdated.PageModels;
using IsaLifeUpdated.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsaLifeUpdated
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = FreshPageModelResolver.ResolvePageModel<HomePageModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
