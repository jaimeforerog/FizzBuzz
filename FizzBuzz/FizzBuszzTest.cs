using FluentAssertions;

namespace FizzBuzz;

public class FizzBuszzTest
{
    [Fact]
    public void Si_Envio_1_Devuelvo_1( )
    {
    // Arrange
    int numero = 1;

    //act
    string resultado=ValidarNumero(numero);

    //assert
    resultado.Should().Be("1");

    }

    [Fact]
    public void Si_Envio_2_Devuelvo_2()
    {
        //arrange
        int numero = 2;

        //act
        string resultado=ValidarNumero(numero);

        //assert
        resultado.Should().Be("2");
    }

    [Fact]
    public void Si_Envio_3_Devuelvo_Fizz()
    {
        //arrange 
        int numero =3;
        
        //act 
        string resultado=ValidarNumero(numero);
        
        //assert
        resultado.Should().Be("Fizz");
    }
    
    [Fact]
    public void Si_Envio_6_Devuelvo_Fizz()
    {
        //arrange 
        int numero =6;
        
        //act 
        string resultado=ValidarNumero(numero);
        
        //assert
        resultado.Should().Be("Fizz");
    }
    
    private string ValidarNumero(int numero)
    { 
        if (numero %3==0) 
            return "Fizz";
        return numero.ToString();
    }
}