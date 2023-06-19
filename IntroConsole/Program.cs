#region Cadenas 

string primernombre= "Christy";
string apellido= "Martínez"; 
string mensaje= @$"Hola, me llamo {primernombre} {apellido} y mi archivo es C:\Users\ejemplo.txt";

//Console.WriteLine(mensaje);

#endregion

#region Numeros

//int num1 = 0;
//int num2 = 0;

//Console.Write("Escribe el primer número: ");
//num1 = int.Parse(Console.ReadLine());

//Console.Write("Escribe el primer número: ");
//num2 = int.Parse(Console.ReadLine());

//decimal resultado = (decimal) num1 / num2;

//Console.WriteLine($"El resultado de la operacion es: {resultado}");

#endregion

#region if

//int x = 20;
//int z = 21;

//string mensajeIf = "";

//if (x > z)
    //mensajeIf = $"{x} es mayor a {z}";
//else if (x< z)
    //mensajeIf = $"{x} es menor a {z}";
//else
    //mensajeIf = $"{x} es igual a {z}";

//Console.WriteLine(mensajeIf); 

#endregion

#region valores

int cantidadretiros = 0;
int[] retiros = null;
int[] valores = {500, 200, 100, 50, 20, 10, 5, 1};
int[] cantidadBilletesMonedas = new int[valores.Length];

#endregion valores

while (true)
{

#region menu

Console.WriteLine("-------------------Banco CDIS-------------------\n");
Console.WriteLine("1. Ingresar la cantidad de retiros hechos por los usuarios.\n");
Console.WriteLine("2. Revisar la cantidad entregada de billetes y monedas.\n\n");
Console.WriteLine("0. Salir");
Console.WriteLine("Ingresa la opción: ");int opc = int.Parse(Console.ReadLine()); 

#endregion menu

#region switch de opciones

switch (opc)
{
    case 1:
    Console.WriteLine("¿Cuántos retiros se hicieron (máximo 10)?");
    cantidadretiros = int.Parse(Console.ReadLine());

    retiros = new int[cantidadretiros];

    for (int i = 0; i < cantidadretiros; i++)
    {
    Console.WriteLine("\nIngrese la cantidad del retiro " + (i + 1) + ":");
    retiros[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("¡Cantidad de retiros y valores ingresados correctamente!\n");
    break;

    case 2:
    if (cantidadretiros == 0)
    {
        Console.WriteLine("ingresar primero las cantidades de retiros y sus valores.\n");
        break;
    }

    Console.WriteLine("Cantidad de billetes y monedas utilizados para cada retiro:\n");

    for (int i = 0; i < cantidadretiros; i++)
    {
        int cantidad = retiros[i];

            for (int j = 0; j < valores.Length; j++)
                {
                cantidadBilletesMonedas[j] = cantidad / valores[j];
                cantidad %= valores[j];
                }

                Console.WriteLine("Para un retiro de " + retiros[i] + " pesos mexicanos:");
                for (int j = 0; j < valores.Length; j++)
                    {
                        if (cantidadBilletesMonedas[j] > 0)
                            {
                                Console.WriteLine(cantidadBilletesMonedas[j] + " billetes/monedas de " + valores[j]);
                            }
                    }

                    Console.WriteLine("-----------------------");
    }

    Console.WriteLine();
    break; 

    case 0:
    Console.WriteLine("¡Transacciones realizadas con exito, gracias por usar Banco CDIS!\n");
    return;

    default:
    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.\n");
    break;
}

}
#endregion