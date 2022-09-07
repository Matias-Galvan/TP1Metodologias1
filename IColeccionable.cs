namespace tp1
{
    public interface IColeccionable
    {
        int cuantos();
        IComparable minimo();
        IComparable maximo();

        void agregar(IComparable comparable);
        bool contiene(IComparable comparable);

        
    }
}