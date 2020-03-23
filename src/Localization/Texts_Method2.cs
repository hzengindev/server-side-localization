using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Localization
{
    public class Texts_Method2
    {
        public static Dictionary<LanguageCode, Dictionary<TextCode, string>> TextDefinitions = new Dictionary<LanguageCode, Dictionary<TextCode, string>>();

        public Texts_Method2()
        {
            var files = Directory.GetFiles("localization-files/");
            foreach (var fileDir in files)
            {
                var definition = JsonConvert.DeserializeObject<Dictionary<TextCode, string>>(File.ReadAllText(fileDir));
                var langCode = Enum.Parse<LanguageCode>(Path.GetFileNameWithoutExtension(fileDir));
                TextDefinitions.Add(langCode, definition);
            }
        }

        public static string GetText(LanguageCode languageCode, TextCode textCode)
        {
            var defaultLang = LanguageCode.Turkish;
            //Tanımlanmayan dil tipleri için default dil ataması yapılıyor
            if (!TextDefinitions.ContainsKey(languageCode))
                languageCode = defaultLang;

            var text = TextDefinitions[languageCode];
            if (text.ContainsKey(textCode))
                return text[textCode];

            return "Undocument code!";
        }
    }
}
