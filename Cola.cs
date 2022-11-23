namespace tp1
{
    public class Cola<T> : IColeccionable, tp1.tp2.Iterable, tp5.IOrdenable
    {
        private List<IComparable> datos;
        //TP5
        tp5.OrdenEnAula1 ordenInicio;
        tp5.OrdenEnAula2 ordenLlegaAlumno;
        tp5.OrdenEnAula1 ordenAulaLlena;

        public Cola()
        {
            datos = new List<IComparable>();
        }

        public void encolar(IComparable elem)
        {
            this.datos.Add(elem);
        }

        public IComparable desencolar()
        {
            IComparable temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }

        public IComparable tope()
        {
            return this.datos[0];
        }

        public bool esVacia()
        {
            return this.datos.Count == 0;
        }

        public int cuantos()
        {
            return datos.Count();
        }

        public IComparable minimo()
        {
            IComparable aux = datos[0];

            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].esMenor(aux))
                {
                    aux = datos[i];
                }
            }
            return aux;
        }

        public IComparable maximo()
        {
            IComparable aux = datos[0];

            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].esMayor(aux))
                {
                    aux = datos[i];
                }
            }
            return aux;
        }

        public void agregar(IComparable elemento)
        {
            //TP5 Ejercicio 9
            if (this.cuantos() == 0)
            {
                ordenInicio.ejecutar();
            }
            ordenLlegaAlumno.ejecutar(elemento);
            encolar(elemento);
            if (this.cuantos() == 40)
            {
                ordenAulaLlena.ejecutar();
            }
        }

        public bool contiene(IComparable elemento)
        {
            bool aux = false;
            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].sosIgual(elemento))
                {
                    aux = true;
                }
            }

            return aux;
        }

        //Metodo iterador

        public tp1.tp2.IteradorComparables crearIterador()
        {
            tp1.tp2.IteradorComparables iterador = new tp1.tp2.iteradorPilaConjuntoCola(datos);
            return iterador;
        }

        //TP5 Command

        public void setOrdenInicio(tp5.OrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }
        public void setOrdenLlegaAlumno(tp5.OrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }
        public void setOrdenAulaLlena(tp5.OrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }
    }
}
