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
    public partial class HelloWorldPages1 : ContentPage
    {
        int countClick = 0;
        //
        public HelloWorldPages1()
        {
            InitializeComponent();
        }
        //
        private void Button_OnClick(object sender, EventArgs args)
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