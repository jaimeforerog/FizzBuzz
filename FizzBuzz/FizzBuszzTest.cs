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

    //accert
    resultado.Should().Be(1);

    }

    private int ValidarNumero(int numero)
    {
        return 1;
    }
}