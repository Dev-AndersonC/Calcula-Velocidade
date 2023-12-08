namespace Testes.Models
{
    public class Robo
    {
        
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
     public void RecebeOsParametrosAcelerarEDesacelera(string texto)
    {
        string textoUpper = texto.ToUpper();
        int contA = textoUpper.Count(c => c == 'A');
        int ContD = textoUpper.Count(c => c == 'D');


        // Console.WriteLine($"Na palavra {texto} possui {contA} - A");
        // Console.WriteLine($"Na palavra {texto} possui {ContD} - D");

        for(int i = 0; i < contA + 1; i++){
            Acelerar();
        }
        for(int i = 0; i < ContD + 1; i++){
            Desacelerar();
        }
    //    return VelocidadeAtual;
    }
    }
}