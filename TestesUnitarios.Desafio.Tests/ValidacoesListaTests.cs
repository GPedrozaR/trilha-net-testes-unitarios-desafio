using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Arrange
        var input = new List<int> { 5, -1, -8, 9 };
        var searchedNumber = 10;

        // Act
        var hasThisNumberInInput = _validacoes.ListaContemDeterminadoNumero(input, searchedNumber);

        // Assert
        Assert.False(hasThisNumberInInput);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Arrange
        var multiplicatorFact = 2;
        var input = new List<int> { 5, 7, 8, 9 };
        var expectedOutput = new List<int> { 10, 14, 16, 18 };

        // Act
        var multiplicatedList = _validacoes.MultiplicarNumerosLista(input, multiplicatorFact);

        // Assert
        Assert.Equal(expectedOutput, multiplicatedList);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var input = new List<int> { 5, -1, -8, 9 };

        // Act
        var maxValueIntoList = _validacoes.RetornarMaiorNumeroLista(input);

        // Assert
        Assert.Equal(9, maxValueIntoList);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var input = new List<int> { 5, -1, -8, 9 };

        // Act
        var maxValueIntoList = _validacoes.RetornarMenorNumeroLista(input);

        // Assert
        Assert.Equal(-8, maxValueIntoList);
    }
}
