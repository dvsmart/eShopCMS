using eShopCMS.Core.ViewModels.Base;
using eShopCMS.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace eShopCMS.Core
{
	public partial class App : Application
	{
        ISettingsService _settingsService;

        public App ()
		{
			InitializeComponent();
            InitApp();

            MainPage = new NavigationPage(new LoginView());
		}

        private void InitApp()
        {
            _settingsService = ViewModelLocator.Resolve<ISettingsService>();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
