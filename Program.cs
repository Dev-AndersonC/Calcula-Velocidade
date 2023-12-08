using System;
using Testes.Models;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
        string EntradaDeValor = RemoverAspas(Console.ReadLine());
        string[] valores = EntradaDeValor.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (valores.Length == 2 &&
            int.TryParse(valores[0], out int CVmn) &&
            int.TryParse(valores[1], out int CVmx))
        {
            string texto = RemoverAspas(Console.ReadLine());
            Robo rb = new Robo(CVmn, CVmx);
            rb.RecebeOsParametrosAcelerarEDesacelera(texto);
            int resultado = Convert.ToInt32(rb.VelocidadeAtual);
            Console.WriteLine(resultado);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir dois valores inteiros separados por espaço ou vírgula.");
        }
    }

    static string RemoverAspas(string input)
    {
        // Remove as aspas simples ou duplas
        return input.Replace("'", "").Replace("\"", "");
    }

            
        }
    }