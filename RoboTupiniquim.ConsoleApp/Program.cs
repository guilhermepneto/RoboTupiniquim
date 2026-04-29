//Robo Tupiniquim

//1ª parte - Input de coordenadas e direção

while (true)
{
    Console.Clear();
    Console.WriteLine("Informe as coordenadas X e Y, respectivamente, e a direção que o robô está olhando (N,S,L,O)");
    string? inputInicial = Console.ReadLine();

    string[] dados = inputInicial.Split(' ');

    string coord_x = dados[0];
    string coord_y = dados[1];
    string direcao = dados[2];

    Console.WriteLine("A posição inicial do robô é: " + coord_x + " " + coord_y + " " + direcao);
    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();

    //2ª parte - Input de sequencia de comandos

    Console.WriteLine("Informe a sequência de comandos que o robô irá percorrer no grid");
    string sequenciaComandos = Console.ReadLine();

    char[] instrucoes = sequenciaComandos.ToCharArray();

    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();


    foreach (char comando in instrucoes)
    {
        if (comando == 'M')
        {
            Console.WriteLine("O robô moveu para frente");
        }
        else if (comando == 'E')
        {
            Console.WriteLine("O robô virou para a esquerda");
        }
        else if (comando == 'D')
        {
            Console.WriteLine("O robô virou para a direita");
        }
    }
    return;

}

