namespace Modelado_ATM
{
   class Transacciones
    {
        // encapsulamiento
        private string _tipo = "";
        private decimal _monto;
        private DateTime _date;

        //control de manejo de datos
        public string Tipo
        {
            get{return _tipo;}
            set{_tipo = value;}
        }

        public decimal Monto
        {
            get{return _monto;}
            set{_monto = value;}
        }

        public DateTime Date
        {
            get{return _date;}
            set{_date = value;}
        }

        // constructor
        public Transacciones(string tipo, decimal monto, DateTime date)
        {
            Tipo = tipo;
            Monto = monto;
            Date = date;
        }

        // metodos
        public void MostrarDetalle()
        {
            Console.WriteLine("Detalle de Transaccion:\n");
            Console.WriteLine($"Tipo de cuenta: {Tipo}, Monto: $RD{Monto:N2}, Fecha: {Date}.");
        }


    }

}