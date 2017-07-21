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
    public partial class DangNhapPage : ContentPage
    {
        int countClick = 0;
        //
        public DangNhapPage()
        {
            InitializeComponent();
        }
        //
        private void Btn_OnClick(object sender, EventArgs args)
        {
            countClick++;
            string name = edt1.Text;
            string pass = edt2.Text;
            if (countClick >= 5)
            {
                txtResult1.Text = "Quá " + countClick + " lần";
                txtResult2.Text = "Không thể đăng nhập";
            }
            else
            {
                txtResult1.Text = "ấn: " + countClick + " lần";
                txtResult2.Text = "name: " + name + " | pass: " + pass;
            }
            //
            edt1.Text = string.Format("");
            edt2.Text = string.Format("");
        }
    }
}