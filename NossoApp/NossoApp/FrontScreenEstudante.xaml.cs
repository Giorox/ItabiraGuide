﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NossoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontScreenEstudante : MasterDetailPage
    {
        public FrontScreenEstudante()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FrontScreenEstudanteMenuItem;
            if (item == null)
                return;

            Global.controllerButtonID = item.Id;
            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}