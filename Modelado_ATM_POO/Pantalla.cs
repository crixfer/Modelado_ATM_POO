namespace Modelado_ATM
{
    class Pantalla
    {
        // metodos

        public void MostrarMensaje(string mensaje) // METODO MOSTRAR MENSAJE
        {
            Console.WriteLine(mensaje);
        }
                
        public decimal MostrarSaldo(string mensaje)
        {
            Cuenta.ConsultarSaldo();
            return Cuenta.Saldo;
        }

    }
}