/*
//--COM IF E ELSE--

int x = 10;
int y = 0;
int resultado;

if(y > 0){
    resultado = x / y;
}
else
{
    Console.WriteLine("Não é possível dividir por zero.");
}
*/

/*
//--COM TRY CATCH--

try
{
    int[] numeros = { 1, 2, 3 };
    Console.WriteLine(numeros[5]);
}
catch (System.Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    //Console.WriteLine("Ocorreu um erro ao acessar o índice do array.");
}
*/

/*
//--COM TRY CATCH ESPECÍFICO (Erro de formatação)--

try
{
    int a = int.Parse("abc");
}
catch (FormatException ex)
{
    Console.WriteLine("Erro de formato: " + ex.Message);
}
catch (System.Exception)
{
    Console.WriteLine("Erro de sistema. Contate o administrador.");
}
finally
{
    Console.WriteLine("Bloco finally executado.");
}
*/


//--COM TRY CATCH ESPECÍFICO (Erro de argumento )--

try
{
    int a = int.Parse("2");
    int idade = -2;

    if (idade < 0)
    {
        throw new IdadeInvalidaException("Idade inválida.");
    }
}
catch (IdadeInvalidaException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Erro de formato: " + ex.Message);
}
catch (System.Exception)
{
    Console.WriteLine("Erro de sistema. Contate o administrador.");
}
finally
{
    Console.WriteLine("Bloco finally executado.");
}
