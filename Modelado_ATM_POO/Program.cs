using System.Runtime.Versioning;

namespace Modelado_ATM
{
    class Program
    {

        //Cuenta del cliente
        Cuenta noCuenta1 = new Cuenta("123456", 25000m, true); 
        Cuenta noCuenta2 = new Cuenta("456789", 5000m, false); // inactiva
        Cuenta noCuenta3 = new Cuenta("789456", 80000m, true);


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a DIGIT-BANK\n");

            Console.WriteLine("Digite su número de cuenta, por favor");
            Console.Write("No. Cuenta: ");
            int validaNoCuenta = int.Parse(Console.ReadLine()!);

            while (true)
            {
                if (validaNoCuenta == 123456)
                {
                    
                }
            }

            ATM.MostrarMenu();
        }
    }
}