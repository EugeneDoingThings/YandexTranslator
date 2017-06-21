using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YandexTranslator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Translate : ContentPage
    {
        public Translate()
        {
            InitializeComponent();

        }
        private void ChangeLang(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "en-ru")
            {
                FirstLang.Text = "Русский";
                SecondLang.Text = "Английский";
                button.Text = "ru-en";
            }
            else
            {
                SecondLang.Text = "Русский";
                FirstLang.Text = "Английский";
                button.Text = "en-ru";
            }
        }
    }
}