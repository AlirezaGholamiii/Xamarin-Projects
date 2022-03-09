using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SecondProject
{
    public partial class ToolsPage2 : ContentPage
    {
        public ToolsPage2()
        {
            InitializeComponent();
        }

        void endDatePicker_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            DateTime newDate = e.NewDate;
            DateTime oldDate = e.OldDate;
            DisplayAlert("new date:", newDate.ToString(), "OK");
        }

        void switch1_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            //Display an alert to show if toggle is on or off
            var switchObj = (Switch)sender;
            if (switchObj.IsToggled)
            {
                DisplayAlert("Toggle is:", "On", "OK");
            } else
            {
                DisplayAlert("Toggle is:", "Off", "OK");
            }
        }

        void Stepper_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            rotateLabel.Rotation = value;
            displayLabel.Text = string.Format("The stepper value is {0}", value);
        }
    }
}
