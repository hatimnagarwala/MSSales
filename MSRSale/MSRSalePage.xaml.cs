using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MSRSale
{
    public partial class MSRSalePage : ContentPage
    {
        public MSRSalePage()
        {
            InitializeComponent();
            loadPickerData();

        }

        private void loadPickerData()
        {
            List<string> locations = new List<string>();
            locations.Add("Carrefour");
            locations.Add("Emax");
            locations.Add("Jumbo");


            LocationPicker.ItemsSource = locations;
        }
    }
}
