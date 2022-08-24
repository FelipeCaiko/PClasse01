using System;
namespace PClasse01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Pessoa pessoa3 = new Pessoa();

            Console.Write("Informe o nome da primeira pessoa: ");
            pessoa1.setNome(Console.ReadLine());

            Console.Write("Informe a data de nascimento da primeira pessoa: ");
            pessoa1.setDtNasc(DateTime.Parse(Console.ReadLine()));

            Console.Write("Informe o CPF da primeira pessoa: ");
            pessoa1.setCpf(Console.ReadLine());

            Console.Write("Informe o telefone da primeira pessoa: ");
            pessoa1.setTelefone(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe o nome da segunda pessoa: ");
            pessoa2.setNome(Console.ReadLine());

            Console.Write("Informe a data de nascimento da segunda pessoa: ");
            pessoa2.setDtNasc(DateTime.Parse(Console.ReadLine()));

            Console.Write("Informe o CPF da segunda pessoa: ");
            pessoa2.setCpf(Console.ReadLine());

            Console.Write("Informe o telefone da segunda pessoa: ");
            pessoa2.setTelefone(Console.ReadLine());

            Console.Clear();

            Console.Write("Informe o nome da terceira pessoa: ");
            pessoa3.setNome(Console.ReadLine());

            Console.Write("Informe a data de nascimento da terceira pessoa: ");
            pessoa3.setDtNasc(DateTime.Parse(Console.ReadLine()));

            Console.Write("Informe o CPF da terceira pessoa: ");
            pessoa3.setCpf(Console.ReadLine());

            Console.Write("Informe o telefone da terceira pessoa: ");
            pessoa3.setTelefone(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine();
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine();
            Console.WriteLine(pessoa3.ToString());
        }
    }
}
