using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item11.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GroupListView());
            };
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());
            };
        }
    }
}
