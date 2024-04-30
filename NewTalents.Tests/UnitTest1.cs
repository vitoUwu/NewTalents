using NewTalents.App;

namespace NewTalents.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 3, 6)]
        [InlineData(5, 5, 10)]
        [InlineData(6, 1, 7)]
        [InlineData(-1, 1, 0)]
        [InlineData(-1, -1, -2)]
        public void SomarDoisNumerosERetornarASomaCorreta(int n1, int n2, int result)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            int soma = calculator.Somar(n1, n2);

            // Assert
            Assert.Equal(result, soma);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(3, 3, 0)]
        [InlineData(5, 5, 0)]
        [InlineData(6, 1, 5)]
        [InlineData(-1, 1, -2)]
        [InlineData(-1, -1, 0)]
        public void SubtrairDoisNumerosERetornarADiferencaCorreta(int n1, int n2, int result)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            int diferenca = calculator.Subtrair(n1, n2);

            // Assert
            Assert.Equal(result, diferenca);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 5, 25)]
        [InlineData(6, 1, 6)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -1, 1)]
        public void MultiplicarDoisNumerosERetornarOMultiplicacaoCorreta(int n1, int n2, int result)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            int multiplicacao = calculator.Multiplicar(n1, n2);

            // Assert
            Assert.Equal(result, multiplicacao);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 3, 1)]
        [InlineData(5, 5, 1)]
        [InlineData(6, 1, 6)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -1, 1)]
        public void DividirDoisNumerosERetornarADivisaoCorreta(int n1, int n2, int result)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            int divisao = calculator.Dividir(n1, n2);

            // Assert
            Assert.Equal(result, divisao);
        }

        [Fact]
        public void DividirNumeroPorZeroDeveRetornarErro()
        {
            // Arrange
            Calculator calculator = new();

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Dividir(1, 0));
        }

        [Fact]
        public void HistoricoDeOperacoesDeveRetornarUmaListaVazia()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            List<string> historico = calculator.Historico();

            // Assert
            Assert.Empty(historico);
        }

        [Fact]
        public void HistoricoDeOperacoesDeveRetornarUmaListaComOperacoesRealizadas()
        {
            // Arrange
            Calculator calculator = new();

            // Act
            calculator.Somar(1, 1);
            calculator.Subtrair(1, 1);
            calculator.Multiplicar(1, 1);
            calculator.Dividir(1, 1);
            List<string> historico = calculator.Historico();

            // Assert
            Assert.Equal(4, historico.Count);
            Assert.Equal("1 + 1 = 2", historico[0]);
            Assert.Equal("1 - 1 = 0", historico[1]);
            Assert.Equal("1 * 1 = 1", historico[2]);
            Assert.Equal("1 / 1 = 1", historico[3]);
        }
    }
}