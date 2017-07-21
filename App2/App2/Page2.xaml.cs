using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();           
        }
        //
        public Page2(string Param)
        {
            InitializeComponent();
            txtPage2.Text = Param;
        }
        //
        private async void Btn_Goback(object sender, EventArgs args)
        {
            await Navigation.PopAsync();// go back
        }
    }
}