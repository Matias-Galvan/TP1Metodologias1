namespace tp1.tp3
{
    public interface IObservado
    {
         void agregarObservador(IObservadores observador);
         void quitarObservador (IObservadores observador);
         void notificar();
    }
}