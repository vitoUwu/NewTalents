namespace NewTalents.App
{
    public class Calculator : ICalculator
    {
        private readonly List<string> historico = [];

        public int Dividir(int n1, int n2)
        {
            int result = n1 / n2;
            historico.Add($"{n1} / {n2} = {result}");
            return result;
        }

        public List<string> Historico()
        {
            return historico;
        }

        public int Multiplicar(int n1, int n2)
        {
            int result = n1 * n2;
            historico.Add($"{n1} * {n2} = {result}");
            return result;
        }

        public int Somar(int n1, int n2)
        {
            int result = n1 + n2;
            historico.Add($"{n1} + {n2} = {result}");
            return result;
        }

        public int Subtrair(int n1, int n2)
        {
            int result = n1 - n2;
            historico.Add($"{n1} - {n2} = {result}");
            return result;
        }
    }
}
