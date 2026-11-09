using System.IO.Pipes;
using System.Runtime.Serialization;

namespace Modelado_ATM
{
    class Cuenta
    {
        private string _numeroCuenta = "";
        private static decimal _saldo;
        private bool _activa;

        // controlled variables_____________________________________

        public string NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }

        public static decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public bool Activa
        {
            get { return _activa; }
            set
            {
                if (Activa == false)
                {
                    Console.WriteLine("La cuenta esta inactiva. Favor contactar a nuestras oficinas para más información.");
                }
                _activa = value;
            }
        }

        // constructor_______________________________________________

        public Cuenta(string numeroCuenta, decimal saldo, bool activa)
        {
            NumeroCuenta = numeroCuenta;
            Saldo = saldo;
            Activa = activa;
        }

        // metodos___________________________________________________

        public static void ConsultarSaldo() // METODO CONSULAR SALDO
        {
            Console.WriteLine($"Su saldo actual es: $RD{Saldo:N2}");
        }

        public decimal Depositar(string mensaje) // METODO DEPOSITAR
        {
            decimal montoOperacion;
            Console.Write(mensaje);

            // loop while para validacion
            while (!decimal.TryParse(Console.ReadLine(), out montoOperacion) || montoOperacion <= 0)
            {
                Console.WriteLine("Debe ingresar un monto válido o mayor a cero!");
                Console.Write(mensaje);
            }

            Console.WriteLine("\n***** Monto agregado satisfactoriamente *****");

            Saldo += montoOperacion;
            ConsultarSaldo(); // metodo consultar saldo
            return Saldo;
        }

        public decimal Retirar(string mensaje) // METODO RETIRAR
        {
            decimal montoOperacion;
            Console.Write(mensaje);

            // loop while para validacion
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out montoOperacion))
                {
                    Console.WriteLine("Debe ingresar un monto válido o mayor a cero!");
                }
                else if (montoOperacion > Saldo)
                {
                    Console.WriteLine("Fondos insuficientes. Intente retirar un monto menor.");
                }
                else
                {
                    break;
                }

                Console.WriteLine(mensaje);
            }

            Saldo -= montoOperacion;
            Console.WriteLine($"\nHa retirado: $RD{montoOperacion:N2}"); // muestra total retirado
            ConsultarSaldo(); // metodo consultar saldo
            return Saldo;

        }
    }
}