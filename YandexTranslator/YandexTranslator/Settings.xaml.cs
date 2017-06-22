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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender,EventArgs e)
        {
            Device.OpenUri(new Uri("https://tech.yandex.ru/dictionary/"));
        }
    }
}