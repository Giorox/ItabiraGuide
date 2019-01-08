using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NossoApp
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnItabira(object sender, EventArgs args)
        {
            if (App.Current.Properties.ContainsKey("Choice"))
                App.Current.Properties["Choice"] = 0;
            else
                App.Current.Properties.Add("Choice", 0);
            App.Current.SavePropertiesAsync();

            itabiranoButton.BackgroundColor = Color.FromHex("#636972");
            unifeiButton.BackgroundColor = Color.WhiteSmoke;
        }

        async void OnUnifei(object sender, EventArgs args)
        {
            if (App.Current.Properties.ContainsKey("Choice"))
                App.Current.Properties["Choice"] = 1;
            else
                App.Current.Properties.Add("Choice", 1);
            App.Current.SavePropertiesAsync();

            unifeiButton.BackgroundColor = Color.FromHex("#636972");
            itabiranoButton.BackgroundColor = Color.WhiteSmoke;
        }

        async void OnGo(object sender, EventArgs args)
        {
            App.Current.SavePropertiesAsync();

            var escolha = Convert.ToInt32(Application.Current.Properties["Choice"]);

            if (escolha == 0)
                App.Current.MainPage = new FrontScreenMorador();
            else if (escolha == 1)
                App.Current.MainPage = new FrontScreenEstudante();
        }
    }
}
