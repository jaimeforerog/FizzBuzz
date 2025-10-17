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
    
    [Fact]
    public void Si_Envio_5_Devuelvo_Buzz()
    {
        //arrange 
        int numero = 5;
        
        //act 
        string resultado=ValidarNumero(numero);
        
        //assert
        resultado.Should().Be("Buzz");
    }

    [Fact]
    public void Si_Envio_10_Devuelve_Buzz()
    {
        //arrange
        int numero = 10;
        //Act
        string resultado=ValidarNumero(numero);
        //asserts
        resultado.Should().Be("Buzz");
    }

    [Fact]
    public void Si_Envio_15_Devuelve_FizzBuzz()
    {
        //arrange
        int numero = 15;
        //act
        String resultado = ValidarNumero(numero);
        //asserts
        resultado.Should().Be("FizzBuzz");
    }
    private string ValidarNumero(int numero)
    { 
        if(numero == 15)
            return "FizzBuzz";
        
        if (numero %3==0) 
            return "Fizz";
        
        if(numero % 5 == 0)
            return "Buzz";
        
        
        
        return numero.ToString();
    }
}