using LibrairieConversionNote;

while (true)
{
    Console.WriteLine("Veuillez entrer une note alphabétique (ou appuyez sur CTRL + C pour quitter) :");
    string input = Console.ReadLine();

    string note = ConversionAlphabetiqueToNote.Transform(input);

    Console.WriteLine(note);
}
