using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new App2.HelloWorldPages1());
            MainPage = new CarouselPage
            {
                //trang con
                Children =
                {
                    new App2.Views.HomePages(),
                    new App2.HelloWorldPages1(),
                    new App2.Page2(),
                    new App2.MainPage(),
                    new App2.Views.DangNhapPage()
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
