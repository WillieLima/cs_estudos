using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraImpTests
{
    private CalculadoraImp _calc;

    public CalculadoraImpTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.Somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);

        // dotnet test para executar o teste
    }
    [Fact]
    public void DeveVerificarSe4EhParESeEhVerdadeiro()
    {
        //arrange
        int num = 4;

        //act
        bool resultado = _calc.EhPar(num);

        //assert
        Assert.True(resultado);
    }

    [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // [InlineData(12)] 
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void VeriricarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //assert
        Assert.All(numeros, x => Assert.True(_calc.EhPar(x)));
    }
}