namespace ExemploContrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Gabriel"; //apenas leitura
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)// padronizar instancias
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Ola, meu nome é {nome} {sobrenome}");
        }
        
    }
}