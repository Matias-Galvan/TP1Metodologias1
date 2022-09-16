namespace tp1
{
    public interface IStrategy
    {
        bool sosIgual(IComparable actual, IComparable comparable);
        bool esMayor(IComparable actual, IComparable comparable);
        bool esMenor(IComparable actual, IComparable comparable);
    }
}