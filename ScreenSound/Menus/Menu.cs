namespace ScreenSound.Menus;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        Console.Clear();
        int tamanhoTitulo = titulo.Length + 4;
        string asterisco = string.Empty.PadLeft(tamanhoTitulo, '*');
        Console.WriteLine(asterisco);
        Console.WriteLine($"* {titulo} *");
        Console.WriteLine(asterisco);
        Console.WriteLine();
    }

    public static void ExibirLogo()
    {
        string logo = @"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀";
        Console.WriteLine(logo);
        Console.WriteLine("Bem vino ao Screen Soud 2.0!");
    }
}
