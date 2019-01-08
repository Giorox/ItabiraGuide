using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Npgsql;
using System.Diagnostics;

namespace NossoApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Categorias : ContentPage
	{
		public Categorias ()
		{
            InitializeComponent();
            //This line invokes a new thread and tells it to run the openDBConnection() function so that there is no application freeze for the user
            System.Threading.Thread myThread = new System.Threading.Thread(new System.Threading.ThreadStart(openDBConnection));
            myThread.Start();
        }

        //public NpgsqlDataReader openDBConnection()
        private async void openDBConnection()
        {
            //Connection String (connString) is a global variable defined in Global.cs that has the connection credentials to the DB maintaind in Heroku's server
            using (NpgsqlConnection conn = new NpgsqlConnection(Global.connString))
            {
                //Try opening the connection
                try
                {
                    conn.Open();
                }
                catch (NpgsqlException ex) //Catch Npgsql connection error and treat it properly, might be a server timeout or a DB server unavailability error (change text in future to better present error to user)
                {
                    Debug.WriteLine(ex.ErrorCode);
                    Device.BeginInvokeOnMainThread(() => {
                        DisplayAlert("Erro", "Não foi possível conectar com o servidor\r\n\r\nVerifique sua conexão com a internet e tente novamente", "OK");
                    });
                    return;
                }
                catch (System.Net.Sockets.SocketException ex) //Catch SocketExcepetion error and treat it, most likely a phone error (change text in future to better present error to user)
                {
                    Debug.WriteLine(ex.ErrorCode);
                    Device.BeginInvokeOnMainThread(() => {
                        DisplayAlert("Erro", "Não foi possível conectar com o servidor\r\n\r\nVerifique sua conexão com a internet e tente novamente", "OK");
                    });
                    return;
                }
                catch
                {
                    return;
                }

                string defaultQuery = "SELECT estabelecimento.nome_estabelecimento,estabelecimento.rua,estabelecimento.numero,estabelecimento.complemento,estabelecimento.bairro,estabelecimento.cidade,estabelecimento.estado,estabelecimento.cep,estabelecimento.h_funcionamento,telefones.num_telefone,telefones.DDD_estabelecimento,estabelecimento.latitude,estabelecimento.longitude,imagens.imagem  FROM public.estabelecimento, public.tipo_estabelecimento, public.telefones, public.imagens ", whereStatement = "";

                //Switch statement to properly choose whereStatement to concatenate with defaultQuery 
                switch(Global.controllerButtonID)
                {
                    case 0:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Emergencia' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 1:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Banco' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 2:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Bar' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 3:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Buffet' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 4:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Chaveiro' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 5:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Distribuidora' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 6:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Escola' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 7:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Farmacia' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 8:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Hospital' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 9:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Hotel' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 10:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Imobiliaria' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 11:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Lanchonete' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 12:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'CompEletronico' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 14:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Padaria' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 15:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Papelaria' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 16:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Pizzaria' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 17:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Restaurante' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 18:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'ServPublico' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 19:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Supermercado' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                    case 20:
                        whereStatement = "WHERE tipo_estabelecimento.num_tipo = estabelecimento.tipo AND tipo_estabelecimento.nome_tipo = 'Turismo' AND telefones.id_dono = estabelecimento.id AND imagens.id_dono = estabelecimento.id;";
                        break;
                }

                defaultQuery = defaultQuery + whereStatement;
                //Executes SQL query inside the queryString towards the connection started through the connString
                NpgsqlCommand cmd = new NpgsqlCommand(defaultQuery, conn);
                NpgsqlDataReader returnInfo = cmd.ExecuteReader();

                //Gets the number of columns in the current table to be used later
                int columnCount = returnInfo.FieldCount;

                //Initializes the StackLayout that defines that objects should be on top of each other and the ScrollView that defines a scrollable screen
                var layout = new StackLayout();
                var scrolllayout = new ScrollView();

                //Creates Gesture Recognizer trigger for the telephone label and create action to open phone app with number filled in
                var telephoneTggr = new TapGestureRecognizer();
                telephoneTggr.Tapped += (s, e) =>
                {
                    Label clickedLabel = (Label)s;
                    Device.OpenUri(new Uri("tel:" + clickedLabel.Text));
                };

                //Creates Gesture Recognizer trigger for the address label and create action to open google maps App or Chrome with maps URL and choosen address
                var addressTggr = new TapGestureRecognizer();
                addressTggr.Tapped += (s, e) =>
                {
                    Label clickedLabel = (Label)s;
                    Device.OpenUri(new Uri("https://www.google.com/maps/search/" + clickedLabel.Text));
                };

                //Read until we have no more lines in the return object and create a new custom block entity for each.
                while (returnInfo.Read())
                {
                    int counter = 0;
                    string[] tupleInfo = new string[columnCount];

                    //Get each column of the record and store it in one of the string vector's field
                    while (counter < columnCount)
                    {
                        try
                        {
                            tupleInfo[counter] = returnInfo.GetString(counter);
                        }
                        catch (System.InvalidCastException ex)
                        {

                        }
                        finally
                        {
                            counter++;
                        }
                    }
                    //Create Address Label ahead of block creation and assign trigger
                    var labelAddress = new Label {TextColor = Color.FromHex("#0000EE"), VerticalOptions = LayoutOptions.Center, Margin = 0, FontSize = 12, HeightRequest = 100, Text = tupleInfo[1] + ", " + tupleInfo[2] + " - " + tupleInfo[4] + ", " + tupleInfo[5] + " - " + tupleInfo[6] };
                    labelAddress.GestureRecognizers.Add(addressTggr);

                    //Create Telephone Label ahead of block creation and assign trigger
                    var labelTelephone = new Label { TextColor = Color.FromHex("#0000EE"), VerticalOptions = LayoutOptions.Center, Margin = 0, FontSize = 12, HeightRequest = 100, Text = "(" + tupleInfo[10] + ") " + tupleInfo[9] };
                    labelTelephone.GestureRecognizers.Add(telephoneTggr);

                    //Create frame template format and fill in current record data
                    var frame = new Frame
                    {
                        Content = new StackLayout
                        {
                            HorizontalOptions = LayoutOptions.Start,
                            Orientation = StackOrientation.Vertical,
                            Children = { new StackLayout { HeightRequest=30, Orientation = StackOrientation.Horizontal, HorizontalOptions=LayoutOptions.Start, Children = {new Image { Source= ImageSource.FromUri(new Uri(tupleInfo[13]))}, new Label { FontAttributes=FontAttributes.Bold, Margin=0, FontSize=12, HeightRequest = 100, Text =tupleInfo[0]} } },
                             new StackLayout { HeightRequest=30, Orientation = StackOrientation.Horizontal,  HorizontalOptions=LayoutOptions.Start, Children = {new Image { VerticalOptions = LayoutOptions.Center, Source ="location32.png", WidthRequest=16, HeightRequest=16 }, labelAddress }},
                             new StackLayout { HeightRequest=25, Orientation = StackOrientation.Horizontal, HorizontalOptions=LayoutOptions.Start, Children = {new Image { VerticalOptions = LayoutOptions.Center, Source ="telephone32.png", WidthRequest=16, HeightRequest=16 }, labelTelephone }},
                             new StackLayout { HeightRequest=25, Orientation = StackOrientation.Horizontal, HorizontalOptions=LayoutOptions.Start, Children = {new Image { VerticalOptions = LayoutOptions.Center, Source ="clock32.png", WidthRequest=16, HeightRequest=16 }, new Label { VerticalOptions = LayoutOptions.Center, Margin = 0, FontSize = 12, HeightRequest = 100, Text =tupleInfo[8]} }}
                            }
                        },
                        OutlineColor = Color.Silver,
                        WidthRequest = 200,
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };

                    //Add previously created and defined frame as a child object of the page's layout
                    layout.Children.Add(frame);
                }

                //Call function on Main Thread to update the current layout, since the function is running on a parallel thread and Android does not permit visual modifications in any thread but Main
                Device.BeginInvokeOnMainThread(() => {
                    scrolllayout.Content = layout;
                    Content = scrolllayout;
                });

            }
        }
    }
}