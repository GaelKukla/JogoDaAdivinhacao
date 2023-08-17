namespace JogoDaAdivinhacao
{
    public class Menu
    {
        public void MenuPrincipal() 
        {
            while (true) 
            { 
                Console.WriteLine("Bem-vindo ao jogo da adivinhação!\n1 - Como funciona.\n2 - Jogar.\n3 - Sair.\nDigite o que deseja fazer: ");
                int esc = int.Parse(Console.ReadLine());

                switch (esc) 
                { 
                    case 1:
                        Console.Clear();
                        MenuFuncionamento();
                        break;
                    case 2:
                        Console.Clear();
                        MenuInicioJogo();
                        break;
                    case 3:
                        Console.WriteLine("Até mais!");
                        Environment.Exit(0);
                        break;
            
                }
            }

        }
        public void MenuFuncionamento() 
        { 
            Console.WriteLine("Como funciona:\n Será gerado, aleatóriamente, um número entre 0 e 100, seu objetivo é acertar esse número, para isso as seguintes coisas acontecem:\n" +
                               "- Você terá 10 tentativas.\n" +
                               "- Você será avisado se o número que procura é maior ou menor que seu palpite.\n" +
                               "- Ao final, você rescebera sua pontuação, sendo 100 a pontuação máxima e 0 a  pontuação mínima.\n" +
                               "- Quando você erra uma tentativa, perde 10 pontos.\n\n" +
                               "Pressione qualquer botão para voltar ao menu principal.\n");
            Console.ReadKey();
            Console.Clear();
            MenuPrincipal();
        }

        public void MenuInicioJogo()
        {
            Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!\nAntes de começar, escolha a sua dificuldade: \n1 - Fácil.\n2 - Médio.\n3 - Difícil.\nDigite: ");
            int escolha = int.Parse(Console.ReadLine());
            Jogo j = new();
            Console.Clear();
            j.Jogar(escolha);
        }

    }
}
