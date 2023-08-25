
//mi primera calculadora


public class MiPrimeraCalculadora
{
    static void Main(string[] args)
    {
        //declaro vatriables de entrada
        int num1, num2, ress, resr, resm, resd;


        //solicito variables por pantalla

        Console.Write("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());


        //realizamos calculos

        ress = num1 + num2;
        resr = num1 - num2;
        resm = num1 * num2;
        resd = num1 / num2;

        ////salidas

        Console.Write("El resultadop de la suma es:" + ress);
        Console.Write("\n");
        Console.Write("El resultado de la resta es:" + resr);
        Console.Write("\n");
        Console.Write("El resultado de la multiplicacion es:" + resm);
        Console.Write("\n");
        Console.Write("El resultado de la division es:" + resd);

    }




}




