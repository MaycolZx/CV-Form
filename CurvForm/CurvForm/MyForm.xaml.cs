using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurvForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyForm : ContentPage
    {
        public MyForm()
        {
            InitializeComponent();
            NacionP.Items.Add("Perú");
            NacionP.Items.Add("Argentina");
            NacionP.Items.Add("Colombia");
            NacionP.Items.Add("Brasil");
            NacionP.Items.Add("Chile");
            NacionP.Items.Add("Ecuador");
            NacionP.Items.Add("El Salvador");
            NacionP.Items.Add("México");

            AptitudP.Items.Add("Inteligencia Emocional");
            AptitudP.Items.Add("Creatividad");
            AptitudP.Items.Add("Iniciativa");
            AptitudP.Items.Add("Trabajo en equipo");
            AptitudP.Items.Add("Resolucion de problemas complejos");
            AptitudP.Items.Add("Capacidad de liderazgo");

        }
        void ButtonSubmitClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new MainPage("Algo"), true);
        }
        void ButtonOcupationPlusClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your occupation" };
            ocupation.Children.Add(entry);
        }
    }
}