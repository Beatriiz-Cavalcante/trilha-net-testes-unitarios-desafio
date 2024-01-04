using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {

        // Arrange
        var texto = "Matrix";
        // o valor da variável deve ser a citada no nome do método
        var resultadoEsperado = texto.Length; // texto.lengt || 6

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        //declarar a variável e asssociar a ela o método correto
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    //Corrigir a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";
        // o valor da variável deve ser a citada no nome do método

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
