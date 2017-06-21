using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace YandexTranslator.ViewModels
{
    class TranslateVM
    {
        public string Word { get; set; }
        public ICommand Translate { get; set; }
        public string Output { get; set; }

        private Page _page;
        public TranslateVM(Page page)
        {
            _page = page;
            Translate = new Command(TranslateWord);
        }
        private async void TranslateWord()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=trnsl.1.1.20170621T134821Z.7218412d155d5d94.084686176a91ba1b3c81df51485aaf385e24c6ca"
                    + "&text=" + Word
                    + "&lang=en-ru");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;
                var json = await responseContent.ReadAsStringAsync();
                Output = json;
            }
        }
}
}
