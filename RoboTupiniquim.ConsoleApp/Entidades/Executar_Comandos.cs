namespace RoboTupiniquim.ConsoleApp.Entidades;

public class Executar_Comandos
{
    public static (int, int, string) ExecutarComandos(int coord_x, int coord_y, string direcao, char[] instrucoes)
    {
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
        return (coord_x, coord_y, direcao);
    }

}
