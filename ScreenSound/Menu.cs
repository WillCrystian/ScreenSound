﻿namespace ScreenSound;

internal class Menu
{
    public void ExibirLogo()
    {
        string logo = @"
╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
┃╰━━┳━━┳━┳━━┳━━┳━╮╱┃╰━━┳━━┳╮╭┳━╮╭━╯┃
╰━━╮┃╭━┫╭┫┃━┫┃━┫╭╮╮╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
┃╰━╯┃╰━┫┃┃┃━┫┃━┫┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
╰━━━┻━━┻╯╰━━┻━━┻╯╰╯╰━━━┻━━┻━━┻╯╰┻━━╯";
        Console.WriteLine(logo);
    }
}