namespace Program
{
    class GitMourePPT
    {
        public int contadorP1 = 0;
        int contadorP2 = 0;

        static void Main(string[] args)
        {
            int opcionP1 = 0;
            int opcionP2 = 0;
            Console.WriteLine("Opciones:\n1 -> piedra\n2 -> papel\n3 -> tijera\n4 -> lagarto\n5 -> spock\n______________________");
            jugada();
        }
        public static void jugada()
        {
            GitMourePPT gitMourePPT = new GitMourePPT();
            int contadorFinal = 0;
            int contadorInicial = 0;
            Console.WriteLine("Cuantas partidas quieres jugar?");
            contadorFinal = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Jugardor uno ingresa tu opcion -->");
                int opcionP1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Jugardor dos ingresa tu opcion -->");
                int opcionP2 = int.Parse(Console.ReadLine());
                Console.WriteLine("__________________________________");
                switch (opcionP1)
                {
                    case 3:
                        switch (opcionP2)
                        {
                            case 2:
                                gitMourePPT.contadorP1++;
                                break;
                            case 4:
                                gitMourePPT.contadorP1++;
                                break;
                            case 5:
                                gitMourePPT.contadorP1++;
                                break;
                        }
                        break;
                    case 2:
                        switch (opcionP2)
                        {
                            case 1:
                                gitMourePPT.contadorP1++;
                                break;
                            case 4:
                                gitMourePPT.contadorP1++;
                                break;
                            case 5:
                                gitMourePPT.contadorP1++;
                                break;
                        }
                        break;
                    case 1:
                        switch (opcionP2)
                        {
                            case 4:
                                gitMourePPT.contadorP1++;
                                break;
                            case 3:
                                gitMourePPT.contadorP1++;
                                break;
                        }
                        break;
                    case 4:
                        switch (opcionP2)
                        {
                            case 5:
                                gitMourePPT.contadorP1++;
                                break;
                            case 2:
                                gitMourePPT.contadorP1++;
                                break;
                        }
                        break;
                    case 5:
                        if (opcionP2 == 3)
                        {
                            gitMourePPT.contadorP1++;
                        }
                        break;
                }
                switch (opcionP2)
                {
                    case 3:
                        switch (opcionP1)
                        {
                            case 2:
                                gitMourePPT.contadorP2++;
                                break;
                            case 4:
                                gitMourePPT.contadorP2++;
                                break;
                            case 5:
                                gitMourePPT.contadorP2++;
                                break;
                        }
                        break;
                    case 2:
                        switch (opcionP1)
                        {
                            case 1:
                                gitMourePPT.contadorP2++;
                                break;
                            case 4:
                                gitMourePPT.contadorP2++;
                                break;
                            case 5:
                                gitMourePPT.contadorP2++;
                                break;
                        }
                        break;
                    case 1:
                        switch (opcionP1)
                        {
                            case 4:
                                gitMourePPT.contadorP2++;
                                break;
                            case 3:
                                gitMourePPT.contadorP2++;
                                break;
                        }
                        break;
                    case 4:
                        switch (opcionP1)
                        {
                            case 5:
                                gitMourePPT.contadorP2++;
                                break;
                            case 2:
                                gitMourePPT.contadorP2++;
                                break;
                        }
                        break;
                    case 5:
                        if (opcionP1 == 3)
                        {
                            gitMourePPT.contadorP2++;
                        }
                        break;
                }
                contadorInicial++;
            } while (contadorInicial < contadorFinal);

            if (gitMourePPT.contadorP1 == gitMourePPT.contadorP2) Console.WriteLine("Tie");
            else if (gitMourePPT.contadorP1 > gitMourePPT.contadorP2) Console.WriteLine("Player 1");
            else if (gitMourePPT.contadorP1 < gitMourePPT.contadorP2) Console.WriteLine("Player 2");
        }
    }
}
