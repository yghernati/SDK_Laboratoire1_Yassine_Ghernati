using System;
namespace LibrairieConversionNote
{
    public static class ConversionAlphabetiqueToNote
    {
        public static string Transform(string noteAlphabetique)
        {
            string note = "";

            switch (noteAlphabetique.ToUpper())
            {
                case "A":
                    note = "la syllabe correspondante a votre choix est : LA";
                    break;
                case "B":
                    note = "la syllabe correspondante a votre choix est : SI";
                    break;
                case "C":
                    note = "la syllabe correspondante a votre choix est : DO";
                    break;
                case "D":
                    note = "la syllabe correspondante a votre choix est : RÉ";
                    break;
                case "E":
                    note = "la syllabe correspondante a votre choix est : MI";
                    break;
                case "F":
                    note = "la syllabe correspondante a votre choix est : FA";
                    break;
                case "G":
                    note = "la syllabe correspondante a votre choix est : SOL";
                    break;
                default:
                    note = "aucune syllabe ne correspond a votre choix !!! reessayer !!!";
                    break;
            }

            return note;
        }
    }
}