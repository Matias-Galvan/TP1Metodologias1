namespace tp1.tp5
{
    public class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;
        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.claseLista();
        }
    }
}