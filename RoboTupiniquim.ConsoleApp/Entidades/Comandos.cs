namespace RoboTupiniquim.ConsoleApp.Entidades;

public class Comandos
{
    public static char[] EntradaComandos()
    {
        Console.WriteLine();
        Console.WriteLine("Informe a sequência de comandos que o robô irá percorrer no grid (E,D ou M)");
        string sequenciaComandos = Console.ReadLine().ToUpper();
        Console.WriteLine();

        return sequenciaComandos.ToCharArray();
    }
}
