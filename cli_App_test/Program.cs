using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Dictionary_lib;
using Word = Microsoft.Office.Interop.Word;


namespace cli_App_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict1 = new Dictionary<string, string>();
            dict1.Add("hello", "привет");
            dict1.Add("go", "идем");
            dict1.Add("buy", "купить");
            dict1.Add("welcome", "добро пожаловать");
            var tranlator1 = new Dictionary_class(dict1);
            Console.WriteLine($"Перевод слова buy - {tranlator1.Translate("buy")} ");
            // var wordApp = new Word.Application();
            // wordApp.Visible = true;
            // wordApp.Documents.Add();
           // wordApp.Selection.PasteSpecial(Link: true, DisplayAsIcon: true);
        }
    }
}