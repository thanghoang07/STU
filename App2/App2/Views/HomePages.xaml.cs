using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePages : ContentPage
    {
        int countClick = 0;
        //
        public HomePages()
        {
            InitializeComponent();
        }
        //
        private void Btn_OnClick(object sender, EventArgs args)
        {
            countClick++;
            if (countClick <= 100)
            {
                txtResult.Text = "ấn: " + countClick + " lần";
            }
            else
            {
                txtResult.Text = "ấn quá: " + countClick + " lần";
            }
        }
    }
}