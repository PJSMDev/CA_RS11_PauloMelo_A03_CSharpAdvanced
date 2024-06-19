// using System.Globalization;

namespace D19_CSharpAdvanced_ExtensionMethods
{

    internal static class ExtensionMethods
    {

        // textForConcat01.ConcatenarParaMaiusculas("Sharp")
        internal static string MyConcatAndUpper(this string t01, string t02)
        {

            string frase = $"{t01} {t02}";

            return frase.ToUpper();

        }

        internal static string MyFormatToEuro(this int v)
        {

            return $"{v:C2}";   // C2: currency 2 decimais

        }

        internal static string MyFormatToEuro(this string t)
        {

            int resultado = int.Parse(t);   // CultureInfo.InvariantCulture

            return resultado.ToString();

        }

    }

}
