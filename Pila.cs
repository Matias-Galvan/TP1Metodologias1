using System.Collections.Generic;
namespace tp1
{
    public class Pila<T> : IColeccionable
    {
        private IColeccionable coleccionable;
        public Queue<T> q1 = new Queue<T>();
        public Queue<T> q2 = new Queue<T>();

        public void apilar(T elemento){
           q2.Enqueue(elemento);

           while(q1.Count > 0){
            q2.Enqueue(q1.Peek());
            q1.Dequeue();
           }
           Queue<T> q3 = q1;
           q1 = q2;
           q2 = q3;
        }

        public void desapilar(){
            if(q1.Count == 0)
            return;
            q1.Dequeue();
        }

        public T tope(){
            if (q1.Count == 0){

            }
             return (T)q1.Peek();
        }

        public int tamaño(){
            return q1.Count;
        }

        public int cuantos(){
            return q1.Count;
        }

        public IComparable minimo(){
            return 
        }
        public IComparable maximo(){

        }
    }
}