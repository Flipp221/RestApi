using RestApi.IRest;
using RestApi.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApi
{
    public partial class App : Application
    {
        public static TodoItemManager TodoManager { get; private set; }
        public App()
        {
            InitializeComponent();
            TodoManager = new TodoItemManager(new RestService());
            MainPage = new NavigationPage(new ToDoEntry());
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
