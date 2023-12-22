using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuMostrarTodasAsBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            ExibirTitulo("Mostrar todas as bandas.");
            Console.WriteLine();
            foreach (var banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"- {banda}");
            }
            Console.WriteLine("\nAperte qualquer tecla para voltar ao menu inicial.");
            Console.ReadKey();
        }
    }
}
