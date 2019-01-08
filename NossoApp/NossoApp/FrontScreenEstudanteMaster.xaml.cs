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
    public partial class FrontScreenEstudanteMaster : ContentPage
    {
        public ListView ListView;

        public FrontScreenEstudanteMaster()
        {
            InitializeComponent();

            BindingContext = new FrontScreenEstudanteMasterViewModel();
            ListView = MenuItemsListView;
        }

        class FrontScreenEstudanteMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FrontScreenEstudanteMenuItem> MenuItems { get; set; }
            
            public FrontScreenEstudanteMasterViewModel()
            {
                MenuItems = new ObservableCollection<FrontScreenEstudanteMenuItem>(new[]
                {
                    new FrontScreenEstudanteMenuItem { Id = 0, Title = "Emergências", TargetType= typeof(Categorias), Icon ="siren.png"},

                    new FrontScreenEstudanteMenuItem { Id = 21, Title = "Mapa da UNIFEI", Icon="map.png" },
                    new FrontScreenEstudanteMenuItem { Id = 22, Title = "Professores", Icon="teacher.png" },
                    new FrontScreenEstudanteMenuItem { Id = 23, Title = "Coordenadores", Icon="organization.png" },
                    new FrontScreenEstudanteMenuItem { Id = 13, Title = "Linhas de Ônibus" ,TargetType= typeof(HorariosDeOnibus), Icon="bus.png"},
                    new FrontScreenEstudanteMenuItem { Id = 24, Title = "Repúblicas", Icon="houses.png" },
                    new FrontScreenEstudanteMenuItem { Id = 25, Title = "Projetos de Extensão", Icon="presentation.png" },

                    new FrontScreenEstudanteMenuItem { Id = 1, Title = "Bancos", TargetType= typeof(Categorias), Icon="bank.png" },
                    new FrontScreenEstudanteMenuItem { Id = 2, Title = "Bares/Pubs", TargetType= typeof(Categorias), Icon="beer.png" },
                    new FrontScreenEstudanteMenuItem { Id = 3, Title = "Buffets", TargetType= typeof(Categorias), Icon="food.png" },
                    new FrontScreenEstudanteMenuItem { Id = 4, Title = "Chaveiros", TargetType= typeof(Categorias), Icon="key.png" },
                    new FrontScreenEstudanteMenuItem { Id = 5, Title = "Distribuidoras", TargetType= typeof(Categorias), Icon="toast.png" },
                    new FrontScreenEstudanteMenuItem { Id = 6, Title = "Escolas", TargetType= typeof(Categorias), Icon="books.png" },
                    new FrontScreenEstudanteMenuItem { Id = 7, Title = "Farmácias", TargetType= typeof(Categorias), Icon="medicine.png" },
                    new FrontScreenEstudanteMenuItem { Id = 8, Title = "Hospitais", TargetType= typeof(Categorias), Icon="hospital.png" },
                    new FrontScreenEstudanteMenuItem { Id = 9, Title = "Hotel", TargetType= typeof(Categorias), Icon="hotel.png"},
                    new FrontScreenEstudanteMenuItem { Id = 10, Title = "Imobiliárias", TargetType= typeof(Categorias), Icon="buyhome.png"},
                    new FrontScreenEstudanteMenuItem { Id = 11, Title = "Lanchonetes", TargetType= typeof(Categorias), Icon="burger.png" },
                    new FrontScreenEstudanteMenuItem { Id = 12, Title = "Lojas de Informática/Componentes Eletrônicos." , TargetType= typeof(Categorias), Icon="monitor.png" },
                    new FrontScreenEstudanteMenuItem { Id = 14, Title = "Padarias", TargetType= typeof(Categorias), Icon="bread.png" },
                    new FrontScreenEstudanteMenuItem { Id = 15, Title = "Papelarias", TargetType= typeof(Categorias), Icon="diary.png"},
                    new FrontScreenEstudanteMenuItem { Id = 16, Title = "Pizzarias", TargetType= typeof(Categorias), Icon="pizza.png" },
                    new FrontScreenEstudanteMenuItem { Id = 17, Title = "Restaurantes", TargetType= typeof(Categorias), Icon="restaurant.png" },
                    new FrontScreenEstudanteMenuItem { Id = 18, Title = "Serviços Públicos", TargetType= typeof(Categorias), Icon="hours.png"  },
                    new FrontScreenEstudanteMenuItem { Id = 19, Title = "Supermercados", TargetType= typeof(Categorias), Icon="carts.png" },
                    new FrontScreenEstudanteMenuItem { Id = 20, Title = "Turismo", TargetType= typeof(Categorias), Icon="suitcase.png" },
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