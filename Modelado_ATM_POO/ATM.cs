namespace Modelado_ATM
{
    class ATM
    {
        private string _cuentaActual = "";

        // control de manejo de datos
        public string CuentaActual
        {
            get{return _cuentaActual;}
            set{_cuentaActual = value;}
        }

        // constructor
        public ATM(string cuentaActual)
        {
            CuentaActual = cuentaActual;
        }

        // metodos
        public void MostrarMenu() // METODO MOSTRAR MENU
        {
            // menu de opciones
                Console.WriteLine("\t\n********** Menú de opciones **********\n");

                Console.WriteLine("1. Consulta de balance disponible.");
                Console.WriteLine("2. Depósito a cuenta.");
                Console.WriteLine("3. Retiro.");
                Console.WriteLine("4. Historial de movimientos.");

                Console.WriteLine("\n5. Salir del menú.");

                Console.WriteLine("\t\n**************************************");

                Console.Write("Opción: ");
            // fin menu de opciones
        }
    }
}