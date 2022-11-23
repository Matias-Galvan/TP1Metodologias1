namespace tp1.tp5
{
    public interface IOrdenable
    {
        public void setOrdenInicio(OrdenEnAula1 orden);
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        public void setOrdenAulaLlena(OrdenEnAula1 orden);
    }
}