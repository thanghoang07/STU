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
        int countClick = 0;
        //
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
        private void Btn_Goback(object sender, EventArgs args)
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