using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NossoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HorariosDeOnibus : ContentPage
	{
		public HorariosDeOnibus ()
		{
            InitializeComponent ();
		}

        async void onBusLineClick(object sender, EventArgs args)
        {
            var button = (Button) sender;
            var buttonClassId = button.ClassId;

            switch (buttonClassId)
            {
                case "BelVilStRuth":
                    var uri = new Uri("https://www.transportescisne.com.br/horarios/010-Bela_Vista_Santa_Ruth.pdf");
                    Device.OpenUri(uri);
                    break;
                case "BelVilStCrist":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/015-Bela_Vista_Sao_Cristovao.pdf");
                    Device.OpenUri(uri);
                    break;
                case "CircA":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/020-Circular_A.pdf");
                    Device.OpenUri(uri);
                    break;
                case "CircB":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/025-Circular_B.pdf");
                    Device.OpenUri(uri);
                    break;
                case "PraiaPedre":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/030-Praia_Pedreira.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Sape":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/035-Sape.pdf");
                    Device.OpenUri(uri);
                    break;
                case "PaJbJK":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/040-Para_Juca_Batista_Via_JK.pdf");
                    Device.OpenUri(uri);
                    break;
                case "PaJbAF":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/045-Para_Juca_Batista_Via_JF.pdf");
                    Device.OpenUri(uri);
                    break;
                case "StMarta":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/050-Santa_Marta.pdf");
                    Device.OpenUri(uri);
                    break;
                case "StTereza":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/055-Santa_Tereza.pdf");
                    Device.OpenUri(uri);
                    break;
                case "ViSerra":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/057-Vila_da_Serra.pdf");
                    Device.OpenUri(uri);
                    break;
                case "StFrancisCDIAF":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/060-Sao_Francisco_CDI_Via_AF.pdf");
                    Device.OpenUri(uri);
                    break;
                case "CampUNIFEI":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/064-UNIFEI.pdf");
                    Device.OpenUri(uri);
                    break;
                case "CooperCDIAF":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/065-Coopervale_CDI_VIA_AF.pdf");
                    Device.OpenUri(uri);
                    break;
                case "PraiaJoao23":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/067-Praia_CDI_Joao_XXIII.pdf");
                    Device.OpenUri(uri);
                    break;
                case "OlivUNIFEI":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/068-Oliveiras_UNIFEI.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Barreiro":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/070-Barreiro.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Beth":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/080-Bethania.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Chap":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/090-Chapada.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Conc":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/100-Conceicao.pdf");
                    Device.OpenUri(uri);
                    break;
                case "CloAlv":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/110-Clovis_Alvim.pdf");
                    Device.OpenUri(uri);
                    break;
                case "NotA":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/120-Noturno_A.pdf");
                    Device.OpenUri(uri);
                    break;
                case "MatA":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/122-Matutino_A.pdf");
                    Device.OpenUri(uri);
                    break;
                case "NotB":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/125-Noturno_B.pdf");
                    Device.OpenUri(uri);
                    break;
                case "FeGabi":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/130-Fenix_Gabiroba.pdf");
                    Device.OpenUri(uri);
                    break;
                case "Bat":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/140-Bateias.pdf");
                    Device.OpenUri(uri);
                    break;
                case "MtStAnt":
                    uri = new Uri("https://www.transportescisne.com.br/horarios/141-Morro_Santo_Antonio.pdf");
                    Device.OpenUri(uri);
                    break;
            }
        }

    }
}