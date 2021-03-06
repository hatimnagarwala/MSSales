﻿using System;
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
            PickerData pData = new PickerData();

            pData.Location = new List<string>(new[] { "SharafDG", "Jumbo", "Carrefour" });
            pData.Category = new List<string>(new[] { "Catergory1", "Category2" });

            LocationPicker.ItemsSource = pData.Location;
            CategoryPicker.ItemsSource = pData.Category;

            List<ListModelSKU> skus = new List<ListModelSKU>();
			skus.Add(new ListModelSKU { Qty = "0", SKU = "Microsoft surface" });
			skus.Add(new ListModelSKU { Qty = "0", SKU = "Microsoft surface" });
			skus.Add(new ListModelSKU { Qty = "0", SKU = "Microsoft surface" });
			skus.Add(new ListModelSKU { Qty = "0", SKU = "Microsoft surface" });
			skus.Add(new ListModelSKU { Qty = "0", SKU = "Microsoft surface" });

            SkuListview.ItemsSource = skus;

        }

        private void submitBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void LocationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    public class ListModelSKU
    {
        public string SKU
        {
            get;
            set;
        }

        public string Qty
        {
            get;
            set;
  
        }

    }

}
