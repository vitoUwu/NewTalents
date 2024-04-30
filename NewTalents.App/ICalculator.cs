namespace NewTalents.App
{
    public interface ICalculator
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2);
        List<string> Historico();
    }
}
