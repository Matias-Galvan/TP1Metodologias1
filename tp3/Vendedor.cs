namespace tp1.tp3
{
    public class Vendedor : tp1.Persona, tp1.IComparable, IObservado
    {
        //Declaracion de campos del vendedor
        Numero sueldo_basico;
        Numero bonus;

        List<IObservadores> lista_gerentes;

        Numero venta;

        //Constructor

        public Vendedor(string nombre, int dni, int sueldo) : base(nombre, dni)
        {
            sueldo_basico = new Numero(sueldo);
            bonus = new Numero(0);
            venta = new Numero(0);
            lista_gerentes = new List<IObservadores>();

        }

        //Metodos

        public void ventaVendedor(int monto)
        {
            venta.setValor(monto);
        }

        public double get_bonus()
        {
            return bonus.getValor();
        }

        public double get_venta()
        {
            return venta.getValor();
        }

        public void aumentarBonus()
        {
            double nuevo_bonus = bonus.getValor() + 0.1;
            bonus.setValor(nuevo_bonus);
        }

        public override string ToString()
        {
            return "Nombre Vendedor: " + this.getNombre() + " Dni: " + this.getDNI() + " SueldoBasico: " + sueldo_basico + " Bonus: " + bonus;
        }

        //Patron observer

        public void agregarObservador(IObservadores gerente)
        {
            lista_gerentes.Add(gerente);
        }
        public void quitarObservador(IObservadores gerente)
        {
            for (int i = 0; i < lista_gerentes.Count; i++)
            {
                if (lista_gerentes[i] == gerente)
                {
                    lista_gerentes.RemoveAt(i);
                }
            }
        }

        public void notificar()
        {
            for (int i = 0; i < lista_gerentes.Count; i++)
            {
                System.Console.WriteLine("El vendedor {0} realizó una venta de {1}", this.getNombre(), this.get_venta());
                lista_gerentes[i].actualizar(this);
            }
        }
    }
}