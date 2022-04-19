using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoEntry : ContentPage
    {
        public ToDoEntry()
        {
            InitializeComponent();
           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            superlist.ItemsSource = await App.TodoManager.GetTasksAsync();
            
        }
    }
}