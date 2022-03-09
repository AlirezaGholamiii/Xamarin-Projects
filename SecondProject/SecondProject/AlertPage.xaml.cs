using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SecondProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private void ButtonType1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "This is an alert", "OK");
        }

        async private void ButtonType2_Clicked(object sender, EventArgs e)
        {
            bool response = await DisplayAlert("Save", "Would you like to save your file?", "Yes", "No");
        }

        async private void ButtonType3_Clicked(object sender, EventArgs e)
        {
            //string result = await DisplayPromptAsync("Question1", "What is your name?");
            string result = await DisplayPromptAsync("Question1", "5 + 5 = ?", initialValue: "10", keyboard: Keyboard.Numeric);
        }

        async private void ButtonType4_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet : Save photo?", "Cancel", "Delete","Not for now");
        }
    }
}