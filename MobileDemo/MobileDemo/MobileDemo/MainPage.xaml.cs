﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void addNewItem_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewItem());
        }
    }
}
