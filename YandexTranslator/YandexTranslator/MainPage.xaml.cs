﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using YandexTranslator.ViewModels;

namespace YandexTranslator
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new TranslateVM(this);
        }
    }
}
