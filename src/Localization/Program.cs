using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Localization
{
    class Program
    {
        static void Main(string[] args)
        {
            var method1_sample1 = Texts_Method1.GetText(TextCode.UserNotFound, LanguageCode.Turkish);
            Console.WriteLine(method1_sample1);
            var method1_sample2 = Texts_Method1.GetText(TextCode.UserNotFound, LanguageCode.German);
            Console.WriteLine(method1_sample2);
            var method1_sample3 = Texts_Method1.GetText(TextCode.EmailIsNotValid, LanguageCode.Turkish);
            Console.WriteLine(method1_sample3);
            var method1_sample4 = Texts_Method1.GetText(TextCode.UserNotFound, LanguageCode.English);
            Console.WriteLine(method1_sample4);

            //------------------------------------------------------------------------------------------

            Texts_Method2 texts_Method2 = new Texts_Method2();
            var method2_sample1 = Texts_Method2.GetText(LanguageCode.Turkish, TextCode.UserNotFound);
            Console.WriteLine(method2_sample1);
            var method2_sample2 = Texts_Method2.GetText(LanguageCode.German, TextCode.UserNotFound);
            Console.WriteLine(method2_sample2);
            var method2_sample3 = Texts_Method2.GetText(LanguageCode.Turkish, TextCode.EmailIsNotValid);
            Console.WriteLine(method2_sample3);
            var method2_sample4 = Texts_Method2.GetText(LanguageCode.English, TextCode.UserNotFound);
            Console.WriteLine(method2_sample4);

            Console.ReadKey();
        }
    }
}
