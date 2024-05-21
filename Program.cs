using EspacioCalculadora;
using Microsoft.VisualBasic.FileIO;


string aux;
int opc, repet = 0;
double num1 = 0;


static int opcionCorrecta()
{
    bool flag = true;
    int opc = 0;
    while (flag)
    {
        string aux;
        Console.WriteLine("Ingrese una Opcion : ");
        aux = Console.ReadLine();
        if (int.TryParse(aux, out opc) && opc <= 5 && opc >= 1)
        {
            flag = false;
        }
        else
        {
            Console.WriteLine("Opcion incorrecta ");
            flag = true;
        }
    }
    return opc;
}

static double doubleCorrecto()
{
    bool flag = true;
    double num = 0;
    while (flag)
    {
        string aux;
        Console.WriteLine("Ingrese un numero: ");
        aux = Console.ReadLine();
        if (double.TryParse(aux, out num))
        {
            flag = false;
        }
        else
        {
            Console.WriteLine("No es un numero!!");
            flag = true;
        }
    }
    return num;
}

Calculadora Operacion = new Calculadora();


while (repet == 0)
{
    Console.WriteLine("================MENU================");
    Console.WriteLine(" 1 - SUMA");
    Console.WriteLine(" 2 - RESTA");
    Console.WriteLine(" 3 - PRODUCTO");
    Console.WriteLine(" 4 - DIVISION");
    Console.WriteLine(" 5 - LIMPIAR");
    Console.WriteLine("===================================");
    opc = opcionCorrecta();
    if (opc != 5 || opc != 6)
    {
        num1 = doubleCorrecto();
    };

    switch (opc)
    {
        case 1:
            Operacion.Suma(num1);
            break;
        case 2:
            Operacion.Resta(num1);
            break;
        case 3:
            Operacion.Multiplicacion(num1);
            break;
        case 4:
            Operacion.Division(num1);
            break;
        case 5:
            Operacion.Limpiar();
            break;
        default:
            break;
    }

    Console.WriteLine($"El resultado parcial es: {Operacion.resultado}");

    Console.WriteLine($"Quiere realizar otra operacion? S / N");
    aux = Console.ReadLine();
    if (aux == "n" || aux == "N")
    {
        repet++;
    }

}

Console.WriteLine($"El resultado final es: {Operacion.resultado}");


Console.WriteLine($"...");


