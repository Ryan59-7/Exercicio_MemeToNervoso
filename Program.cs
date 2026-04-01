﻿string Mensagem, RespostaMeme;
Console.Write("Usuário, o que você pensa sobre mim? ");
Mensagem = Console.ReadLine()!;

RespostaMeme =
    $"{Mensagem.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(RespostaMeme);
