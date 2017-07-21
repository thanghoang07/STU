using App2.MenuItems;
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
    public partial class HomePages : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public HomePages()
        {
            InitializeComponent();

            MenuList = new List<MasterPageItem>();

            var page1 = new MasterPageItem() { Title = "Thông tin", Icon = "itemIcon1.png", TargetType = typeof(App2.Views.AboutPage) };
            var page2 = new MasterPageItem() { Title = "Đăng ký", Icon = "itemIcon2.png", TargetType = typeof(App2.Views.DangKyPage) };
            var page3 = new MasterPageItem() { Title = "Đăng nhập", Icon = "itemIcon3.png", TargetType = typeof(App2.Views.DangNhapPage) };
            var page4 = new MasterPageItem() { Title = "Item 4", Icon = "itemIcon4.png", TargetType = typeof(App2.Views.PreDangNhapPage) };
            var page5 = new MasterPageItem() { Title = "Tài khoản", Icon = "itemIcon5.png", TargetType = typeof(App2.Views.ProfilePage) };
            var page6 = new MasterPageItem() { Title = "Quên mật khẩu", Icon = "itemIcon6.png", TargetType = typeof(App2.Views.QuenMatKhauPage) };
            var page7 = new MasterPageItem() { Title = "Cài đặt", Icon = "itemIcon7.png", TargetType = typeof(App2.Views.SettingPage) };
            var page8 = new MasterPageItem() { Title = "Page2", Icon = "itemIcon8.png", TargetType = typeof(App2.Page2) };
            var page9 = new MasterPageItem() { Title = "Main ", Icon = "itemIcon9.png", TargetType = typeof(App2.MainPage) };

            // Adding menu items to menuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);
            MenuList.Add(page7);
            MenuList.Add(page8);
            MenuList.Add(page9);
            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(App2.Views.AboutPage)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}