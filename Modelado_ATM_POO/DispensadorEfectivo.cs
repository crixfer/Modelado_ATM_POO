namespace Modelado_ATM
{
    class DispensadorEfectivo
    {
        private decimal _efectivoDisponible;

        // control y manejo de datos
        public decimal EfectivoDisponible
        {
            get{return _efectivoDisponible;}
            set{_efectivoDisponible = value;}
        }

        // constructor
        public DispensadorEfectivo(decimal efectivoDisponible)
        {
            EfectivoDisponible = efectivoDisponible;
        }

        // metodos
        public void DispensarEfectivo()
        {
            Console.WriteLine("Presete atentción al dispensador para retirar su efectivo.");
            Console.WriteLine("****(Sonido de selección de papeletas en proceso. ffffrrrr)****");
        }

    }
}