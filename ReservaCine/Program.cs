int[,] butaca = new int[10, 10];
int opcion;
do
{
    Console.WriteLine("!Bienvenido a HOYTS¡");
    Console.WriteLine("1. Ver sala");
    Console.WriteLine("2. Reservar butaca");
    Console.WriteLine("3. Cancelar reserva");
    Console.WriteLine("4. Limpiar consola");
    Console.WriteLine("5. Salir");
    Console.Write("Indique la opción deseada:");
    opcion = Convert.ToInt32(Console.ReadLine());



    switch (opcion)
    {
        case 1:
            
            imprimirSala();

            break;

        case 2:
            Console.Write("Ingrese fila:");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese columna:");
            int j = Convert.ToInt32(Console.ReadLine());

            if (butaca[i,j] == 1){
                Console.WriteLine("Butaca no disponible, ingrese otra.");
            } else
            {
                butaca[i, j] = 1;
                Console.WriteLine("Butaca reservada con éxito. Presione enter para continuar");
                Console.ReadLine();
            }

            
            break;

        case 3:

            Console.Write("Ingrese fila:");
            int o = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese columna:");
            int k = Convert.ToInt32(Console.ReadLine());

            if (butaca[o,k] == 1)
            {
                butaca[o, k] = 0;
                Console.WriteLine("Baja de reserva exitosa.");
            } else if (butaca[o,k] == 0)
            {
                Console.WriteLine("Butaca no reservada. Adiós");
            }

            break;


        case 4:
            Console.Clear();
                break;


    }
} while (opcion != 5);
void imprimirSala()
{

    Console.WriteLine("      PANTALLA");
    for (int i = 1; i < 10; i++)
    {

        for (int j = 1; j < 10; j++)
        {

            Console.Write(butaca[i, j] + " ");

        }
        Console.WriteLine();

    }


}
