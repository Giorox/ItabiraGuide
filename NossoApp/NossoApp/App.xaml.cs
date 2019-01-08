using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Xamarin.Forms;
using Npgsql;
using NpgsqlTypes;

namespace NossoApp
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();
            Global.connString = "Host=ec2-50-19-224-165.compute-1.amazonaws.com;Port=5432;Username=gzkxcvsrsrgrjz;Password=897359efd46a83e33303d04d975c4bbc3707eeb0f381317810544c8a1d401429;Database=dfv69mgijtvj1h;SSL Mode=Prefer;Trust Server Certificate=true";
            if (App.Current.Properties.ContainsKey("Choice"))
            {
                var escolha = Convert.ToInt32(Application.Current.Properties["Choice"]);

                if (escolha == 0)
                    MainPage = new NossoApp.FrontScreenMorador();
                else if (escolha == 1)
                    MainPage = new NossoApp.FrontScreenEstudante();
            }
            else
                MainPage = new NavigationPage(new NossoApp.MainPage());
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
