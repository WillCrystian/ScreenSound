using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuFinalizar : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            for (int i = 3; i >= 0; i--)
            {
                Console.Clear();
                ExibirLogo();
                Console.WriteLine($"\nEstamos finalizando em {i}.");
                Thread.Sleep(1000);
            }
        }
    }
}
