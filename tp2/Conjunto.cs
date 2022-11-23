namespace tp1.tp2
{
    public class Conjunto : IColeccionable, Iterable, tp5.IOrdenable
    {
        private List<IComparable> listaConjunto;

        //TP5
        tp5.OrdenEnAula1 ordenInicio;
        tp5.OrdenEnAula2 ordenLlegaAlumno;
        tp5.OrdenEnAula1 ordenAulaLlena;

        public Conjunto()
        {
            listaConjunto = new List<IComparable>();
        }

        public bool pertenece(IComparable comparable)
        {
            bool aux = false;
            for (int i = 0; i < listaConjunto.Count; i++)
            {
                if (listaConjunto[i].sosIgual(comparable))
                {
                    aux = true;
                    break;
                }
            }
            return aux;
        }
        public void agregar(IComparable comparable)
        {
            if (pertenece(comparable))
            {
                for (int i = 0; i < listaConjunto.Count; i++)
                {
                    if (listaConjunto[i].sosIgual(comparable))
                    {
                        listaConjunto[i] = comparable;
                        break;
                    }
                }
            }
            else
            {
                if (listaConjunto.Count == 0)
                {
                    ordenInicio.ejecutar();
                }
                ordenLlegaAlumno.ejecutar(comparable);
                listaConjunto.Add(comparable);

                if (listaConjunto.Count == 40)
                {
                    ordenAulaLlena.ejecutar();
                }
            }
        }

        public int cuantos()
        {
            return listaConjunto.Count;
        }

        public IComparable minimo()
        {
            IComparable aux = listaConjunto[0];

            for (int i = 0; i < listaConjunto.Count; i++)
            {
                if (listaConjunto[i].esMenor(aux))
                {
                    aux = listaConjunto[i];
                }
            }
            return aux;
        }

        public IComparable maximo()
        {
            IComparable aux = listaConjunto[0];

            for (int i = 0; i < listaConjunto.Count; i++)
            {
                if (listaConjunto[i].esMayor(aux))
                {
                    aux = listaConjunto[i];
                }
            }
            return aux;
        }

        public bool contiene(IComparable comparable)
        {
            bool aux = false;

            for (int i = 0; i < listaConjunto.Count; i++)
            {
                if (listaConjunto[i].sosIgual(comparable))
                {
                    aux = true;
                }
            }
            return aux;
        }

        //Metodo iterable

        public IteradorComparables crearIterador()
        {
            IteradorComparables iterador = new iteradorPilaConjuntoCola(listaConjunto);
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