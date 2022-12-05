using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurvForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string mainContentProperty;

        public string MainContentProterpy
        {
            get { return mainContentProperty; }
            set
            {
                mainContentProperty = value;
                OnPropertyChanged(nameof(MainContentProterpy));
            }
        }

        public MainPage(string mainContent)
        {
            InitializeComponent();
            BindingContext = this;
            MainContentProterpy = mainContent;
        }
    }
}
