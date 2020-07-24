using System;

namespace GameTop
{
    public class JogoFoda
    {
        public readonly Jogador jogador;

        public JogoFoda(Jogador jogador)
        {
            this.jogador = jogador;
        }

        public void IniciarJogo()
        {
            Console.WriteLine($"{jogador.Nome} deu um passe");
        }
    }
}