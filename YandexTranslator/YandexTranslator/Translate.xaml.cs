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
        string direction = "en-ru";
        int count = 1;
        public Translate()
        {
            InitializeComponent();

        }
        private void ChangeLang(object sender, System.EventArgs e)
        {
            count += 1; //Button button = (Button)sender;
            if (count%2 == 0)
            {
                FirstLang.Text = "Русский";
                SecondLang.Text = "Английский";
                direction = "ru-en";
            }
            else
            {
                SecondLang.Text = "Русский";
                FirstLang.Text = "Английский";
                direction = "en-ru";
            }
        }
    }
}