int[] numeros = new int[10];
//int[] pares = new int[10];
//int[] impares = new int[10];

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o {i+1}o valor: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i]+" ");
}
Console.ReadKey();

for(int i = 0;i < 10; i++)
{
    if (numeros[i]%2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
Console.ReadKey();

for (int i = 0; i < 10; i++)
{
    if (numeros[i]%2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
Console.ReadKey();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(pares[i]);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(impares[i]);
//}
//Console.ReadKey();

Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[9]);
Console.ReadKey();