﻿internal class Programa
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Isabella Pires");

        // Mudar a cor de fundo
        // Vermelho
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(" Birds of a Feather ");

        //Voltar a cor padrão
        Console.ResetColor();

        // Mudar cor da letra
        // Branco
        Console.ForegroundColor = ConsoleColor.White;
        // String com várias linhas
        Console.Write(@"I want you to stay
Till I'm in the grave
Till I rot away, dead and buried
Till I'm in the casket you carry

If you go, I'm going too, uh
'Cause it was always you, alright
(And if I'm turning blue, please, don't save me)
Nothing left to lose without my baby ");

        // Mudar cor da letra
        //Verde
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        // String com várias Linhas
        Console.Write(@"   Birds of a feather, we should stick together
I know I said I'd never think I wasn't better alone
Can't change the weather, might not be forever
But if it's forever, it's even better");

        // Mudar cor da letra
        // Branco
        Console.ForegroundColor = ConsoleColor.White;
        // String com várias linhas
        Console.Write(@"And I don't know what I'm crying for
I don't think I could love you more
It might not be long, but, baby, I ");
    }
}