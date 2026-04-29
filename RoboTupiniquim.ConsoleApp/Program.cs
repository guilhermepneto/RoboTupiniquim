using RoboTupiniquim.ConsoleApp.Entidades;

namespace RoboTupiniquim.ConsoleApp;

class Program
{
    static void Main()
    {
        while (true)
        {
            var (coord_x, coord_y, direcao) = Coordenadas.EntradaCoordenadas();
            char[] instrucoes = Comandos.EntradaComandos();
            (coord_x, coord_y, direcao) = Executar_Comandos.ExecutarComandos(coord_x, coord_y, direcao, instrucoes);

            Console.WriteLine("Movendo robô, aguarde enquanto concluímos a ação...");
            Console.WriteLine();
            Thread.Sleep(2000);

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Movimento concluído. A posição final do robô é: {coord_x} {coord_y} {direcao}");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Deseja executar o programa novamente? (s/N)");
            string? opcaocontinuar = Console.ReadLine()?.ToUpper();

            if (opcaocontinuar != "S")
                break;

        }

    }
}


