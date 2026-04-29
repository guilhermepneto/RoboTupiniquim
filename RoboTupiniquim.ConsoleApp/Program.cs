//Robo Tupiniquim

while (true)
{
    //1ª parte - Input de coordenadas e direção

    Console.Clear();
    Console.WriteLine("Informe as coordenadas X e Y, respectivamente, e a direção que o robô está olhando (N,S,L,O)");
    string? inputInicial = Console.ReadLine();

    string[] dados = inputInicial.Split(' ');

    int coord_x = Convert.ToInt32(dados[0]);
    int coord_y = Convert.ToInt32(dados[1]);
    string direcao = dados[2].ToUpper();

    Console.WriteLine("A posição inicial do robô é: " + coord_x + " " + coord_y + " " + direcao);

    //2ª parte - Input de sequencia de comandos

    Console.WriteLine("");
    Console.WriteLine("Informe a sequência de comandos que o robô irá percorrer no grid (E,D ou M)");
    string sequenciaComandos = Console.ReadLine().ToUpper();
    Console.WriteLine("");

    char[] instrucoes = sequenciaComandos.ToCharArray();

    //3ª parte - Execução da sequência de comandos

    foreach (char comando in instrucoes)
    {
        switch (comando)
        {
            case 'M':
                switch (direcao)
                {
                    case "N":
                        coord_y++;
                        break;

                    case "S":
                        coord_y--;
                        break;

                    case "L":
                        coord_x++;
                        break;

                    case "O":
                        coord_x--;
                        break;
                }
                break;

            case 'E':
                switch (direcao)
                {
                    case "N":
                        direcao = "O";
                        break;

                    case "O":
                        direcao = "S";
                        break;

                    case "S":
                        direcao = "L";
                        break;

                    case "L":
                        direcao = "N";
                        break;
                }
                break;

            case 'D':
                switch (direcao)
                {
                    case "N":
                        direcao = "L";
                        break;

                    case "O":
                        direcao = "N";
                        break;

                    case "S":
                        direcao = "O";
                        break;

                    case "L":
                        direcao = "S";
                        break;
                }
                break;
        }
    }
    Console.WriteLine("Movendo robô, aguarde enquanto concluímos a ação...");
    Console.WriteLine("");
    Thread.Sleep(2000);
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("Movimento concluído. A posição final do robô é: " + coord_x + " " + coord_y + " " + direcao);
    Console.WriteLine("-----------------------------------------------------");

    Console.WriteLine("");
    Console.WriteLine("Deseja executar o programa novamente? (s/N)");
    string opcaocontinuar = Console.ReadLine().ToUpper();

    if (opcaocontinuar != "S")
        break;

}

