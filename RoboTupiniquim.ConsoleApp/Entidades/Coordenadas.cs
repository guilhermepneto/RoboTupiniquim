namespace RoboTupiniquim.ConsoleApp.Entidades;

public class Coordenadas
{
    public static (int, int, string) EntradaCoordenadas()
    {
        Console.Clear();
        Console.WriteLine("Informe as coordenadas X e Y, respectivamente, e a direção que o robô está olhando (N,S,L,O)");
        string? inputInicial = Console.ReadLine();

        string[] dados = inputInicial.Split(' ');

        int coord_x = Convert.ToInt32(dados[0]);
        int coord_y = Convert.ToInt32(dados[1]);
        string direcao = dados[2].ToUpper();

        Console.WriteLine($"A posição inicial do robô é: {coord_x} {coord_y} {direcao}");

        return (coord_x, coord_y, direcao);
    }
}
