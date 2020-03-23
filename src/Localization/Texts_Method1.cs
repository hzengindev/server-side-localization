using System.Collections.Generic;
using System.Linq;

namespace Localization
{
    public static class Texts_Method1
    {
        public static Dictionary<TextCode, Dictionary<LanguageCode, string>> TextDefinitions = new Dictionary<TextCode, Dictionary<LanguageCode, string>>() {
            {
                TextCode.UserNotFound, new Dictionary<LanguageCode, string>()
                {
                    { LanguageCode.English, "User not found!" },
                    { LanguageCode.Turkish, "Kullanıcı bulunamadı!" },
                }
            },
            {
                TextCode.UsernameIsEmpty, new Dictionary<LanguageCode, string>()
                {
                    { LanguageCode.English, "Username is empty!" },
                    { LanguageCode.Turkish, "Kullanıcı adı boş!" },
                }
            }
        };

        public static string GetText(TextCode textCode, LanguageCode languageCode)
        {
            var defaultLang = LanguageCode.Turkish;

            if (!TextDefinitions.ContainsKey(textCode))
                return "Undocumented code!";

            var text = TextDefinitions[textCode];

            if (text.ContainsKey(languageCode))
                return text[languageCode];
            else
                return text[defaultLang];
        }
    }
}