using Sol_Demo.Data;
using Sol_Demo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<PersonData>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}