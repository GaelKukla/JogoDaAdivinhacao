namespace JogoDaAdivinhacao
{
    public class Jogo
    {
        public int[] dificuldade = {15, 10, 5};

        public void Jogar(int d) 
        {
            Random rnd = new();
            int numeroRandom = rnd.Next(0, 101);
            int tentativa = dificuldade[d-1];
            int pontuacao = 100;
            List<int> tentativas = new List<int>(); 
            while (true)
            {
                Console.Write($"Você tem {tentativa} tentativas.\nPalpites já feitos: ");
                tentativas.ForEach(n => {Console.Write($"{n}; ");});
                Console.Write("\nDigite um número: ");
                int num = int.Parse(Console.ReadLine());
                tentativas.Add(num);
                if (num > numeroRandom)                
                    Console.WriteLine("O numero que você deve advinhar é menor.");
                else if (num < numeroRandom)
                    Console.WriteLine("O numero que você deve advinhar é maior.");
                else
                {
                    Console.WriteLine("Você ganhou!");
                    break;
                }
                tentativa--;
                pontuacao -= 10;
                if (tentativa == 0)
                {
                    Console.WriteLine("Você perdeu!");
                    break;
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine($"Sua pontuação foi: {pontuacao}\nDeseja jogar novamente?\n1 - Sim\n2 - Não\nDigite: ");
            int e = int.Parse(Console.ReadLine());
            if (e == 1)
                Jogar(d);
        }
        
    }
}
