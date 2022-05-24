
Console.WriteLine("Ingresar primer numero: ");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar segundo numero: ");
int numero2 = int.Parse(Console.ReadLine());
int div;
try
{
    div = numero1 / numero2;
    Console.WriteLine("El resultado es: "+ div);

}catch(DivideByZeroException ex)when(numero2==0)
{
    Console.WriteLine("No se puede dividir por 0");
}
finally 
{
    
}
