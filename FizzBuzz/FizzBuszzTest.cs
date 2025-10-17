using FluentAssertions;

namespace FizzBuzz;

public class FizzBuszzTest
{
    [Fact]
    public void Si_Envio_1_Devuelvo_1( )
    {
    // Arrange
    var numero = 1;

    //act
    var resultado=ValidarNumero(numero);

    //assert
    resultado.Should().Be(1);

    }

    [Fact]
    public void Si_Envio_2_Devuelvo_2()
    {
        //arrange
        var numero = 2;

        //act
        var resultado=ValidarNumero(numero);

        //assert
        resultado.Should().Be(2);
    }

    private int ValidarNumero(int numero)
    {
        
        return numero;
    }
}