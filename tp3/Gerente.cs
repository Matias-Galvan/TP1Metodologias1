namespace tp1.tp3
{
    public class Gerente : IObservadores
    {
        List<Vendedor> mejores;

        //Constructor

        public Gerente()
        {
            mejores = new List<Vendedor>();
        }

        public void venta(double monto, Vendedor vendedor)
        {
            bool encontrarVendedor = false;

            if (monto > 5000)
            {
                for (int i = 0; i < mejores.Count; i++)
                {
                    if (mejores[i] == vendedor)
                    {
                        encontrarVendedor = true;
                    }
                }
                if (encontrarVendedor == false)
                {
                    vendedor.aumentarBonus();
                    mejores.Add(vendedor);
                }
            }
        }

        public void cerrar()
        {
            for (int i = 0; i < mejores.Count; i++)
            {
                System.Console.WriteLine("Los mejores vendedores son: ");
                System.Console.WriteLine("Nombre: {0} ", ((Vendedor)mejores[i]).getNombre());
            }
        }

        public void actualizar(IObservado observador)
        {
            venta(((Vendedor)observador).get_venta(), ((Vendedor)observador));
        }
    }
}