﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Noon : ContentPage
    {
        public Noon()
        {
            InitializeComponent();
        }
        private void Add_Activity(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddActivity());
        }
    }
}