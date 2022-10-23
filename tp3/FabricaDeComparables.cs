namespace tp1.tp3
{
    public interface FabricaDeComparables
    {
        abstract public IComparable crearAleatorio();
        abstract public IComparable crearPorTeclado();

        public static IComparable crear_Comparable(string opcion)
        {
            FabricaDeComparables fabrica_comparables;

            switch (opcion)
            {
                case "NumeroSeleccionable":
                    fabrica_comparables = new FabricaDeNumeros();
                    return fabrica_comparables.crearPorTeclado();

                case "AlumnoSeleccionable":
                    fabrica_comparables = new FabricaDeAlumnos();
                    return fabrica_comparables.crearPorTeclado();

                case "NumeroRandom":
                    fabrica_comparables = new FabricaDeNumeros();
                    return fabrica_comparables.crearPorTeclado();

                case "AlumnoRandom":
                    fabrica_comparables = new FabricaDeAlumnos();
                    return fabrica_comparables.crearAleatorio();

                case "VendedorSeleccionable":
                    fabrica_comparables = new FabricaDeVendedores();
                    return fabrica_comparables.crearPorTeclado();

                case "VendedorRandom":
                    fabrica_comparables = new FabricaDeVendedores();
                    return fabrica_comparables.crearAleatorio();

                default:
                    return null;

            }

        }
    }
}