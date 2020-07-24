using System;

namespace GameTop
{
    public class Jogador
    {
        public readonly string Nome;

        public Jogador(string nome)
        {
            this.Nome = nome;
        }

        public void Chutar()
        {
            Console.WriteLine($"{Nome} está Chutando");
        }

        public void Corre()
        {
            Console.WriteLine($"{Nome} está Correndo");
        }

        public void Passe()
        {
            Console.WriteLine($"{Nome} está Passando");
        }
    }
}