namespace tp1.tp5
{
    public class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.comenzar();
        }
    }
}