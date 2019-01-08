using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NossoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontScreenMoradorMaster : ContentPage
    {
        public ListView ListView;

        public FrontScreenMoradorMaster()
        {
            InitializeComponent();

            BindingContext = new FrontScreenMoradorMasterViewModel();
            ListView = MenuItemsListView;
        }

        class FrontScreenMoradorMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FrontScreenMoradorMenuItem> MenuItems { get; set; }
            
            public FrontScreenMoradorMasterViewModel()
            {
                MenuItems = new ObservableCollection<FrontScreenMoradorMenuItem>(new[]
                {
                    new FrontScreenMoradorMenuItem { Id = 0, Title = "Emergências", TargetType= typeof(Categorias), Icon ="siren.png"},
                                   
                    new FrontScreenMoradorMenuItem { Id = 1, Title = "Bancos", TargetType= typeof(Categorias), Icon="bank.png" },
                    new FrontScreenMoradorMenuItem { Id = 2, Title = "Bares/Pubs", TargetType= typeof(Categorias), Icon="beer.png" },
                    new FrontScreenMoradorMenuItem { Id = 3, Title = "Buffets", TargetType= typeof(Categorias), Icon="food.png" },
                    new FrontScreenMoradorMenuItem { Id = 4, Title = "Chaveiros", TargetType= typeof(Categorias), Icon="key.png" },
                    new FrontScreenMoradorMenuItem { Id = 5, Title = "Distribuidoras", TargetType= typeof(Categorias), Icon="toast.png" },
                    new FrontScreenMoradorMenuItem { Id = 6, Title = "Escolas", TargetType= typeof(Categorias), Icon="books.png" },
                    new FrontScreenMoradorMenuItem { Id = 7, Title = "Farmácias", TargetType= typeof(Categorias), Icon="medicine.png" },
                    new FrontScreenMoradorMenuItem { Id = 8, Title = "Hospitais", TargetType= typeof(Categorias), Icon="hospital.png" },
                    new FrontScreenMoradorMenuItem { Id = 9, Title = "Hotel", TargetType= typeof(Categorias), Icon="hotel.png"},
                    new FrontScreenMoradorMenuItem { Id = 10, Title = "Imobiliárias", TargetType= typeof(Categorias), Icon="buyhome.png"},
                    new FrontScreenMoradorMenuItem { Id = 11, Title = "Lanchonetes", TargetType= typeof(Categorias), Icon="burger.png" },
                    new FrontScreenMoradorMenuItem { Id = 12, Title = "Lojas de Informática/Componentes Eletrônicos." , TargetType= typeof(Categorias), Icon="monitor.png" },
                    new FrontScreenMoradorMenuItem { Id = 13, Title = "Linhas de Ônibus" ,TargetType= typeof(HorariosDeOnibus), Icon="bus.png"},
                    new FrontScreenMoradorMenuItem { Id = 14, Title = "Padarias", TargetType= typeof(Categorias), Icon="bread.png" },
                    new FrontScreenMoradorMenuItem { Id = 15, Title = "Papelarias", TargetType= typeof(Categorias), Icon="diary.png"},
                    new FrontScreenMoradorMenuItem { Id = 16, Title = "Pizzarias", TargetType= typeof(Categorias), Icon="pizza.png" },
                    new FrontScreenMoradorMenuItem { Id = 17, Title = "Restaurantes", TargetType= typeof(Categorias), Icon="restaurant.png" },
                    new FrontScreenMoradorMenuItem { Id = 18, Title = "Serviços Públicos", TargetType= typeof(Categorias), Icon="hours.png"  },
                    new FrontScreenMoradorMenuItem { Id = 19, Title = "Supermercados", TargetType= typeof(Categorias), Icon="carts.png" },
                    new FrontScreenMoradorMenuItem { Id = 20, Title = "Turismo", TargetType= typeof(Categorias), Icon="suitcase.png" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}